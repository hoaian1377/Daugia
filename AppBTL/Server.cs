using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Data.SqlClient;
using BCrypt.Net; // Add BCrypt.Net for password hashing

class LoginServer
{
    static TcpListener server = new TcpListener(IPAddress.Any, 8888);

    static void Main()
    {
        server.Start();
        Console.WriteLine("Server started...");

        while (true)
        {
            TcpClient client = server.AcceptTcpClient();
            Console.WriteLine("Client connected!");

            new System.Threading.Thread(() => HandleClient(client)).Start();
        }
    }

    static void HandleClient(TcpClient client)
    {
        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[1024];
        int bytesRead = stream.Read(buffer, 0, buffer.Length);
        string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
        string[] credentials = message.Split('|');
        string username = credentials[0];
        string password = credentials[1];

        string response = CheckLogin(username, password) ? "Login success" : "Login failed";
        byte[] data = Encoding.ASCII.GetBytes(response);
        stream.Write(data, 0, data.Length);

        client.Close();
    }

    static bool CheckLogin(string username, string password)
    {
        string str = "Data Source=DESKTOP-AV5VHME;Initial Catalog=QLKH;Integrated Security=True;Encrypt=true;TrustServerCertificate=True";
        using (SqlConnection conn = new SqlConnection(str))
        {
            try
            {
                conn.Open();
                // Fetch the hashed password from the database
                using (SqlCommand cmd = new SqlCommand("SELECT MK FROM tb_KhachhHang WHERE TenTk=@TenTk", conn))
                {
                    cmd.Parameters.AddWithValue("@TenTk", username);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // Ensure the password is retrieved as a string
                        string hashedPassword = result.ToString();

                        // Debug logging for verification
                        Console.WriteLine("Hashed Password from DB: " + hashedPassword);
                        Console.WriteLine("Plaintext Password Provided: " + password);

                        // Verify the password with bcrypt
                        bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(password, hashedPassword);
                        Console.WriteLine("Password Match Result: " + isPasswordCorrect);

                        return isPasswordCorrect;
                    }
                    else
                    {
                        // Username not found
                        Console.WriteLine("Username not found in the database.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during login verification: " + ex.Message);
                return false;
            }
        }
    }
}
