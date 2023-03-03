class program{
    public static void Main(string[]args){
        Console.Write("Please input 6 digit password : ");
        string password = Console.ReadLine();
        int number0 = (int)Char.GetNumericValue(password[0]);
        int number1 = (int)Char.GetNumericValue(password[1]);
        int number2 = (int)Char.GetNumericValue(password[2]);
        int number3 = (int)Char.GetNumericValue(password[3]);
        int number4 = (int)Char.GetNumericValue(password[4]);
        int number5 = (int)Char.GetNumericValue(password[5]);
        Console.Write("Please input key: ");
        string key = Console.ReadLine();
        if(key=="CIA"){
            if((number5%3 == 0)&&(number4!=1||number4!=3||number4!=5)&&(number2>6&&number2!=8)){
                Console.WriteLine("True");
            }
            else{
                Console.WriteLine("False");
            }
        }
        else if(key == "FBI"){
            if((number0>3&&number0<8)&&(number3%2==0&&number3!=6)&&(number1%2==1)){
                Console.WriteLine("True");
            }
            else{
                Console.WriteLine("False");
            }
        }
        else if (key == "NSA"){
            if((number5==1||number5==2||number5==5||number5==6)&&(number3%3==0 && number3%2!=0)){
                int i=0;
                if(number5==7){
                    i++;
                }
                if(number4==7){
                    i++;
                }
                if(number3==7){
                    i++;
                }
                if(number2==7){
                    i++;
                }
                if(number1==7){
                    i++;
                }
                if(number0==7){
                    i++;
                }
                if(i>0){
                    Console.WriteLine("True");
                }
                else{
                    Console.WriteLine("Fale");
                }
            }
                else{
                    Console.WriteLine("False");
                }
                }
                else{
                    Console.WriteLine("False");
                }
            }
        }