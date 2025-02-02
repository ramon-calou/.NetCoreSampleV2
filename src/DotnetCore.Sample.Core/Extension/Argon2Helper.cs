using Isopoh.Cryptography.Argon2;

namespace DotnetCore.Sample.Core.Extension
{
    public static class Argon2Helper
    {
        public static string GerarHashSenha(string senha)
        {
            return Argon2.Hash(senha);
        }

        public static bool VerificarSenha(string senhaDigitada, string senhaHashArmazenada)
        {
            return Argon2.Verify(senhaHashArmazenada, senhaDigitada);
        }
    }
}