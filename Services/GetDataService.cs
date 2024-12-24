namespace Lab11.Services
{
    public class GetDataService : IGetData
    {
        public int firstNum {  get; private set; }
        public int secondNum { get; private set; }
        public GetDataService() 
        {
            Random random = new Random();
            firstNum = random.Next() % 10;
            secondNum = random.Next() % 10;
        }

        public int Summ()
        {
            return firstNum + secondNum;
        }

        public int Sub()
        {
            return firstNum - secondNum;
        }

        public int Mult()
        {
            return firstNum * secondNum;
        }

        public int Div()
        {
            if (secondNum == 0)
                return -1;
            else
                return firstNum / secondNum;
        }
    }
}
