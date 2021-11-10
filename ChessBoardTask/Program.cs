namespace ChessBoardTask
{
    public class Program
    {
        public static int CellSize = 50;

        public static void Main(string[] args)
        {
            var redColor = new byte[500, 500];
            var blueColor = new byte[500, 500];
            var greenColor = new byte[500, 500];

            DrawChessBoard(redColor, blueColor, greenColor);
            WriteRedDiagonal(redColor, blueColor, greenColor);

            ImageHelper.WriteImage("ChessBoardWithRedDiagonals.bmp", redColor, greenColor, blueColor);
        }

        public static void WriteRedDiagonal(byte[,] redColor, byte[,] blueColor, byte[,] greenColor)
        {
            // TODO: Напишите реализацию данного метода
            // Ожидается, что этот метод рисует ИСКЛЮЧИТЕЛНО КРАСНЫЕ КЛЕТОЧКИ НА ГЛАВНОЙ ДИАГОНАЛИ
            // И другие клеточки вообще не трогает

            // Размер клеточки зависит от статического поля CellSize
            
            for (int i = 0; i < redColor.GetLength(0); i+=CellSize)
            {
                for (int x = 0; x < CellSize; x++)
                {
                    for (int y = 0; y < CellSize; y++)
                    {
                        redColor[i + x, i + y] = 255;
                        blueColor[i + x, i + y] = 0; 
                        greenColor[i + x, i + y] = 0;
                    }
                }
            }
            
        }

        public static void DrawChessBoard(byte[,] redColor, byte[,] blueColor, byte[,] greenColor)
        {
            // TODO: Напишите реализацию данного метода
            // Ожидается, что этот метод рисует шахматную доску.
            // В левом верхнем углу первая клеточка - БЕЛАЯ. 

            // Пример:
            // Б Ч Б Ч ...
            // Ч Б Ч Б ...
            // Б Ч Б Ч ...
            // ...........

            // Размер клеточки зависит от статического поля CellSize. 
            // Если там указано 50 значит размер клеточки должен быть ровно 50х50

            for (int i = 0; i < redColor.GetLength(0)/CellSize; i++)
            {
                for (int j = 0; j < redColor.GetLength(0)/CellSize; j++)
                {
                    for (int x = 0; x < CellSize; x++)
                    {
                        for (int y = 0; y < CellSize; y++)
                        {
                            if ((i+j)%2 ==0 )
                            {
                                redColor[x + i*CellSize, y + j*CellSize] = 255;
                                blueColor[x + i*CellSize, y + j*CellSize] = 255;
                                greenColor[x + i*CellSize, y + j*CellSize] = 255;
                            }
                            else
                            {
                                redColor[x + i*CellSize, y + j*CellSize] = 0;
                                blueColor[x + i*CellSize, y + j*CellSize] = 0; 
                                greenColor[x + i*CellSize, y + j*CellSize] = 0;
                            }
                        
                        }
                    } 
                }
                
            }
        }
    }
}
