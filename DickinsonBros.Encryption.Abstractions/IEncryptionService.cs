namespace DickinsonBros.Encryption.Abstractions
{
    public interface IEncryptionService
    {
        string Decrypt(string encryptedString);
        string Encrypt(string rawString);
    }
}
