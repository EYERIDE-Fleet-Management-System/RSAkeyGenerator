using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;

var rsa = RSA.Create(2048);
var key = new RsaSecurityKey(rsa);
var xml = key.Rsa.ToXmlString(true);
var filename = !args.Any() || string.IsNullOrEmpty(args[0]) ? $"rsa-{DateTimeOffset.UtcNow.UtcTicks}.xml" : args[0];

File.WriteAllText(filename, xml);