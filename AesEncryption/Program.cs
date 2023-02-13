// See https://aka.ms/new-console-template for more information

using AesEncryption;
string password = @"X@X4v3kGY;56#\\2Ez6?R8<#S";
var message = "Hello, World!";
var encypted = StringCipher.Encrypt(message, password);
var decrypted = StringCipher.Decrypt(encypted, password);

Console.WriteLine($"Encrypted: {encypted}");
Console.WriteLine($"Decrypted: {decrypted}");
Console.ReadKey();
