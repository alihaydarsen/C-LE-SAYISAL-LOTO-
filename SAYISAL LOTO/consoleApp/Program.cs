// SAYISAL LOTO 
using System.Diagnostics;

Console.WriteLine("SATISAL LOTOYA HOŞGELDİNİZ");
Console.WriteLine("-------------------------- \n \n \n");
Console.WriteLine("*****OYUN KURALLARI*****\n \n \n");
Console.WriteLine("1-OYUNA BAŞLAMADAN ÖNCE YATIRDIĞINIZ TUTARI GİRMELİSİNİZ");
Console.WriteLine("2-YATIRDIĞIN TUTUR MİN:10TL MAX:5000TL OLMALIDIR");
Console.WriteLine("3-10 TANE RAKAM SEÇEREK LOTOYU TAHMİN ETMEYE ÇALIŞIRSINIZ ");
Console.WriteLine("4-EĞER 4 VEYA DAHA FAZLA RAKAMIN YERİNİ DOĞRU BİLİRSEN KAZANCIN ŞÖYLE OLUR ");
Console.WriteLine("5-4 TANE RAKAMIN YERİ DOĞRUYSA YATIRDIĞIN TUTARIN 10 KATINI KAZANIRSIN ");
Console.WriteLine("6-5 TANE RAKAMIN YERİ DOĞRUYSA YATIRDIĞIN TUTARIN 20 KATINI KAZANIRSIN ");
Console.WriteLine("7-6 TANE RAKAMIN YERİ DOĞRUYSA YATIRDIĞIN TUTARIN 50 KATINI KAZANIRSIN ");
Console.WriteLine("8-7 TANE RAKAMIN YERİ DOĞRUYSA YATIRDIĞIN TUTARIN 100 KATINI KAZANIRSIN ");
Console.WriteLine("9-8 TANE RAKAMIN YERİ DOĞRUYSA YATIRDIĞIN TUTARIN 1000 KATINI KAZANIRSIN ");
Console.WriteLine("10-9 TANE RAKAMIN YERİ DOĞRUYSA YATIRDIĞIN TUTARIN 10000 KATINI KAZANIRSIN ");
Console.WriteLine("11-TÜM RAKAMLARIN YERİ DOĞRUYSA YATIRDIĞIN TUTARIN 100000 KATINI KAZANIRSIN \n\n\n ");
Console.WriteLine("!!!BOL ŞANS!!!");
Console.WriteLine("********************************");

Console.WriteLine("OYNAMAK İSTEDİĞİNİZ TUTARI GİRİNİZ");
int tutar;
tutar=Convert.ToInt32(Console.ReadLine());
Boolean tutarKontrol=true;

while(tutarKontrol==true){
if(tutar<10 || tutar>5000){
Console.WriteLine("YATIRDIĞIN TUTUR MİN:10TL MAX:5000TL OLMALIDIR");
Console.WriteLine("YENİ TUTAR GİRİNİZ");
tutar=Convert.ToInt32(Console.ReadLine());
}else {
    tutarKontrol=false;

}}
Console.WriteLine("--------------------------\n\n\n");
Console.WriteLine("LOTO TAHMİNLERİNİZİ GİRİN :");

 int[] tahmin=new int[10];

 for(int i=1;i<=10;i++){
 Console.WriteLine($"{i}.sıradaki tahminim:");
 tahmin[i-1]= Convert.ToInt32(Console.ReadLine());
 }
 int[]loto=new int[10];
 Random rnd=new Random();

 for(int i=1;i<=10;i++){
 
 loto[i-1]=rnd.Next(0, 10) ;
 }
 Console.WriteLine("\n\n");
int dogruTahmin=0;
 for(int i=1;i<=10;i++){
    if(tahmin[i-1]== loto[i-1]){
        Console.WriteLine($"{i}.tahminiz doğru");
        dogruTahmin=dogruTahmin+1;

    }
    
 }
 Console.WriteLine("\n\n");
 Console.WriteLine("SİZİN TAHMİNİNİZ:"); 
  for(int i=0;i<=9;i++){
    Console.Write(tahmin[i]);
  }
  Console.WriteLine("\n\n");
  Console.WriteLine("LOTO SONUÇLARI");
for(int i=0;i<=9;i++){
    Console.Write(loto[i]);
  }
Console.WriteLine("\n\n");
 if(dogruTahmin>=4){
    if(dogruTahmin==4){
         Console.WriteLine($"TEBRİKLERR!!{tutar*10}TL KAZANDINIZ");
    }else if(dogruTahmin==5){
        Console.WriteLine($"TEBRİKLERR!!{tutar*20}TL KAZANDINIZ");
    }else if(dogruTahmin==6){
        Console.WriteLine($"TEBRİKLERR!!{tutar*50}TL KAZANDINIZ");
    }else if(dogruTahmin==7){
        Console.WriteLine($"TEBRİKLERR!!{tutar*100}TL KAZANDINIZ");
    }else if(dogruTahmin==8){
        Console.WriteLine($"TEBRİKLERR!!{tutar*1000}TL KAZANDINIZ");
    }else if(dogruTahmin==9){
        Console.WriteLine($"TEBRİKLERR!!{tutar*10000}TL KAZANDINIZ");
    }else if(dogruTahmin==10){
        Console.WriteLine($"TEBRİKLERR!!{tutar*100000}TL KAZANDINIZ");
    
 }}else{
         Console.WriteLine($"MAALESEF KAYBETTİNİZ {tutar} TL");
    }
  