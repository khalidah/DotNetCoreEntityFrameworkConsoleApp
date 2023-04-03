

using ConvertANDInsertImage.DataContext;
using ConvertANDInsertImage.Model;
using System.Text.RegularExpressions;

namespace ConvertANDInsertImage
{
    class program
    {
        // private ISMSSenderService smsSenderService = new SMSSenderService();

        static void Main(string[] args)
        {

            Console.WriteLine("Insert New Employee Record");
            Console.WriteLine(".............................");

            InsertRecord();

            /*

            var files = Directory.GetFiles("D:\\ApplicantImage", "*.*", SearchOption.AllDirectories);

            List<string> imageFiles = new List<string>();
            foreach (string filename in files)
            {

                string pattern = @"585";

                if (Regex.IsMatch(filename, pattern))
                {
                    //string filepath = @"D:\ApplicantImage" + filename.Trim();
                    imageFiles.Add(filename);
                    byte[] imageArray = System.IO.File.ReadAllBytes(filename);
                    string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                }
            }

            */


        }

        static void InsertRecord()
        { 
            string stcode, stname, email;

            Console.WriteLine("Enter Employee Code");
            stcode = Console.ReadLine();

            Console.WriteLine("Enter Employee Name");
            stname = Console.ReadLine();

            Console.WriteLine("Enter Email");
            email = Console.ReadLine();

            using (var conn = new ApplicationDbContext())
            { 
                EmployeeClass emp = new EmployeeClass();
                emp.EmployeeCode = stcode.ToString();
                emp.EmployeeName = stname.ToString();
                emp.email = email.ToString();
                conn.Add(emp);
                conn.SaveChanges();

            }
            return;
        }


    }// End Namespace

}