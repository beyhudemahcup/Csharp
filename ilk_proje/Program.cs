
Console.WriteLine("dostlar selam");

// Console.WriteLine("isminizi girin");
// string name = Console.ReadLine();
// Console.WriteLine("soyadinizi girin");
// string soyad = Console.ReadLine();
// Console.WriteLine("merhaba " + name + " " + soyad);

//klasik system.in li olan sey javadaki

string str1 = string.Empty;
Console.WriteLine(str1);//lol

int a = 15;
string rakam = "3";

int sonSayi = a + Convert.ToInt32(rakam);
                  //rakam olan string degiskeni bir integera cevirdi ve gereken mat islemini yapti
Console.WriteLine(sonSayi);// 15+3ten 18 geldi

int strRakamConverted = int.Parse(rakam);
                        //parse ile ayni donusumu saglayabiliyoruz
