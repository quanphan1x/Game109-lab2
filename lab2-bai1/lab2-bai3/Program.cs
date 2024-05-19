using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UserData
{
    public int? id;
    public string name;
    public List<double> scores;

    public UserData()
    {
        id = null;
        name = null;
        scores = new List<double>();
    }

}
public class program
{
    public static void Main(string[] args)
    {
        UserData userData = new UserData();
        Console.WriteLine("nhap ten: ");
        userData.name = Console.ReadLine();
        Console.WriteLine("UserData.name: " + userData.name);

        Console.WriteLine("nhap id:");
        string id = Console.ReadLine();
        userData.id = Convert.ToInt32(id);
        Console.WriteLine("UserData.id: " + userData.id);
        Console.ReadLine();

        Console.WriteLine("nhap danh sacch diem. Nhap so luong can nhap:");
        int soLuongdiem = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < soLuongdiem; i++)
        {
            userData.scores.Add(Convert.ToDouble(Console.ReadLine()));
        }
        Console.WriteLine("danh sach diem vua nhap la:");
        foreach (var i in userData.scores)
        {
            Console.WriteLine(" " + i);
        }
        Console.ReadLine();
    }
}