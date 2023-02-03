// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

//1. (x>0 and y>0)
//2. (x<0 and y>0)
//3. (x<0 and y<0)
//4. (x>0 and y<0)

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    System.Console.WriteLine($"Точка с координатами x = {x} и y = {y} находится в первой четверти");
}
if (x < 0 && y > 0)
{
    System.Console.WriteLine($"Точка с координатами x = {x} и y = {y} находится во второй четверти");
}
if (x < 0 && y < 0)
{
    System.Console.WriteLine($"Точка с координатами x = {x} и y = {y} находится в третьей четверти");
}
if (x > 0 && y < 0)
{
    System.Console.WriteLine($"Точка с координатами x = {x} и y = {y} находится в четвертой четверти");
}
