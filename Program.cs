﻿using System.IO;
Console.WriteLine("Добро пожаловать в программу шифрования по методу ШИФР ЦЕЗАРЯ");
Console.WriteLine("Что будем делать? (1)Шифровать или (2)Расшифровывать");
string userAns = Console.ReadLine();
switch (userAns) {
    case "1":
        Shifrovanie();
        break;
    case "2":
        Rasshifrovanie();
        break;
    default:
        //что-то пошло не так(
        break;
}

void Shifrovanie() {
    Console.WriteLine("Введите фразу для шифрования и нажмите ENTER");
    string userInput = Console.ReadLine();
    Console.WriteLine("Укажите сдвиг шифра в виде целого числа и нажмите ENTER");
    int sdvig = int.Parse(Console.ReadLine());
    string alfavit = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
    string newAlfavit = "";
    for (int i = 0; i < alfavit.Length; i++) {
        int j = i + sdvig;
        if (j > 32) {
            j = j - 33;
        }
        newAlfavit += alfavit[j];
    }
    Console.WriteLine(alfavit);
    Console.WriteLine(newAlfavit);
    string shifr = "";
    for (int i = 0; i < userInput.Length; i++) {
        int letterNumber = alfavit.IndexOf(userInput[i]);
        Console.Write(newAlfavit[letterNumber]);
        shifr += newAlfavit[letterNumber];
    }
    File.WriteAllText("res.txt", sdvig.ToString());
    File.AppendAllText("res.txt", shifr);
}
void Rasshifrovanie() {
    string userFileText = File.ReadAllText("res.txt");
    int sdvig = int.Parse(userFileText[0].ToString());
    string newString="";
    for (int i = 1; i <userFileText.Length ; i++)
    {
        newString+=userFileText[i];
    }
    Console.WriteLine("Сдвиг равен:{0}",sdvig);
    Console.WriteLine("Зашифрованное слово:{0}",newString);
}

