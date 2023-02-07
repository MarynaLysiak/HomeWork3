// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputNumber(string stroka)
{
    System.Console.Write(stroka);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = InputNumber("Введите координату х1: ");
int x2 = InputNumber("Введите координату x2: ");
int y1 = InputNumber("Введите координату y1: ");
int y2 = InputNumber("Введите координату y2: ");
int z1 = InputNumber("Введите координату z1: ");
int z2 = InputNumber("Введите координату z2: ");

double distance = Math.Round((Math.Sqrt(Math.Pow((x2-x1),2)+ Math.Pow((y2-y1),2)+Math.Pow((z1-z2),2))),3);
System.Console.WriteLine(distance);