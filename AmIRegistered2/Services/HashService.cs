using AmIRegistered2.Models;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AmIRegistered2.Services
{
    public class HashService
    {
        private HashDBContext db = new HashDBContext();

        public Boolean DoesHashExist(string hash)
        {
            if (db.Hash.Any(o => o.HashValue == hash.ToUpper()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public String HashString(string inputString)
        {
            inputString = PrepareStringForHash(inputString);
            // convert string to bytes for use in SHA256
            byte[] inputBytes = Encoding.Unicode.GetBytes(inputString);
            // Initialise Encryption Object
            SHA256 mySHA256 = SHA256Managed.Create();
            // Encrypt the byte[]
            byte[] hashBytes = mySHA256.ComputeHash(inputBytes);
            // Convert the byte[] back to a string
            string hashedString = null;
            foreach (byte x in hashBytes)
            {
                hashedString += String.Format("{0:x2}", x);
            }
            return hashedString;
        }

        private string PrepareStringForHash(string inputString)
        {
            // lowercase
            inputString = inputString.ToLower();
            // remove white space
            inputString = inputString.Replace(" ", String.Empty);
            // Return the parsed string
            return inputString;
        }
    }
}