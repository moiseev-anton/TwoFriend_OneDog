int count = 0;
int n = 2;
double time = 0;

Console.Write("Введите растоянние между друзьями ");
double distance = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите скорость первого друга ");
double speedF1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите скорость второго друга ");
double speedF2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите скорость собаки ");
double speedDog = Convert.ToDouble(Console.ReadLine());

while (distance > 1)
{
    if (n > 1)
    {
        time = distance / (speedDog + speedF2);
        n = 1;
    }
    else
    {
        time = distance / (speedDog + speedF1);
        n = 2;
    }
    distance = distance - (speedF1 + speedF2) * time;
    count = count + 1;
}
Console.WriteLine("Собака пробежит " + count + " раз");