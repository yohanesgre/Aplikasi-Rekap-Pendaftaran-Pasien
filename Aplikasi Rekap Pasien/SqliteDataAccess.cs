using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;
using Dapper;

namespace Aplikasi_Rekap_Pasien
{
    public class SqliteDataAccess
    { 
        public static bool CheckIfPasienExist (int noRM = 0)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
               return cnn.ExecuteScalar<int>("SELECT COUNT(*) from DataPasien Where NoRM like '" + noRM + "'") > 0;
            }
        }

        public static bool CheckIfPasienExist(string name = "")
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.ExecuteScalar<int>("SELECT COUNT(*) from DataPasien Where NamaPasien like '" + name + "'") > 0;
            }
        }

        public static List<PasienModel> findPasien(int noRM)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PasienModel>("SELECT * FROM DataPasien WHERE NoRM = "+ noRM+"", new DynamicParameters());
                return output.OrderBy(o => o.noRM).ToList();
            }
        }

        public static List<PasienModel> findPasienByName(string namaPasien)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PasienModel>("SELECT * FROM DataPasien WHERE NamaPasien = '" + namaPasien + "'", new DynamicParameters());
                return output.OrderBy(o => o.noRM).ToList();
            }
        }

        public static List<PasienModel> loadPasien()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PasienModel>("SELECT * from DataPasien", new DynamicParameters());
                return output.OrderBy(o => o.noRM).ToList();
            }
        }

        public static void SavePasien(PasienModel pasien)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                Console.WriteLine(LoadConnectionString());
                cnn.Execute("INSERT INTO DataPasien (NoRM, NamaPasien, TempatLahir, TanggalLahir, Umur, JenisKelamin, WargaNegara, Agama, NamaAyah, NamaIbu, " +
                    "PekerjaanOrtu, Alamat, NoTelp) " +
                    "VALUES (@noRM, @namaPasien, @tempatLahir, @tanggalLahir, @umur, @jenisKelamin, @wargaNegara, @agama, @namaAyah, " +
                    "@namaIbu, @pekerjaanOrtu, @alamat, @noTelp)", pasien);
            }
        }

        public static void UpdatePasien(PasienModel pasien)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                Console.WriteLine(LoadConnectionString());
                cnn.Execute("UPDATE DataPasien SET NoRM = @noRM, " +
                    "NamaPasien = @namaPasien, TempatLahir = @tempatLahir, " +
                    "TanggalLahir = @tanggalLahir, Umur = @umur, " +
                    "JenisKelamin = @jenisKelamin, WargaNegara = @wargaNegara, " +
                    "Agama = @agama, NamaAyah = @namaAyah, " +
                    "NamaIbu = @namaIbu, PekerjaanOrtu = @pekerjaanOrtu, " +
                    "Alamat = @alamat, NoTelp = @noTelp " +
                    "WHERE NoRM = @noRM", pasien);
            }
        }

        public static void DeletePasien(string noRM)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM DataPasien WHERE NoRM = " + noRM + "");
            }
        }

        public static List<PendaftaranModel> loadPendaftaran()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PendaftaranModel>("SELECT * from DataPendaftaran", new DynamicParameters());
                return output.OrderBy(o => o.tanggalDaftar).ToList();
            }
        }

        public static void SavePendaftaran(PendaftaranModel pendaftaran)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO DataPendaftaran (TanggalDaftar, NoRM, NamaPendaftar, JenisKelamin) " +
                    "VALUES (@tanggalDaftar, @noRM, @namaPendaftar, @jenisKelamin)", pendaftaran);
            }
        }

        public static List<PendaftaranModel> loadPendaftaranWhere(string nama, string no, string range1, string range2)
        {
            if (nama == "" & no == "")
            {

                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<PendaftaranModel>("SELECT * FROM DataPendaftaran " +
                        "WHERE TanggalDaftar >='" + range1 + "' AND TanggalDaftar <='" + range2 + "'", new DynamicParameters());
                    return output.OrderBy(o => o.tanggalDaftar).ToList();
                }
            }
            else if (no == "")
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<PendaftaranModel>("SELECT * FROM DataPendaftaran " +
                        "WHERE NamaPendaftar == '" + nama + "' " +
                        "AND TanggalDaftar >='" + range1 + "' AND TanggalDaftar <='" + range2 + "'", new DynamicParameters());
                    return output.OrderBy(o => o.tanggalDaftar).ToList();
                }
            }
            else if (nama == "")
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<PendaftaranModel>("SELECT * FROM DataPendaftaran " +
                        "WHERE NoRM == '" + no + "' " +
                        "AND TanggalDaftar >='" + range1 + "' AND TanggalDaftar <='" + range2 + "'", new DynamicParameters());
                    return output.OrderBy(o => o.tanggalDaftar).ToList();
                }
            }
            else
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<PendaftaranModel>("SELECT * FROM DataPendaftaran " +
                        "WHERE NoRM == '" + no + "' AND NamaPendaftar == '"+ nama +"' " +
                        "AND TanggalDaftar >='" + range1 + "' AND TanggalDaftar <='" + range2 + "'", new DynamicParameters());
                    return output.OrderBy(o => o.tanggalDaftar).ToList();
                }
            }
        }

        public static void deletePendaftaran(string noRM)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM DataPendaftaran WHERE NoRM = " + noRM + "");
            }
        }

        public static bool CheckIfUserExist(string user = "")
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.ExecuteScalar<int>("SELECT COUNT(*) from User Where Username like '" + user + "'") > 0;
            }
        }

        public static bool CheckLogin(string user = "", string password = "")
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string decryptedPassword = SqliteDataAccess.GetDecryptedPassword(password);
                if (password == SqliteDataAccess.GetDecryptedPassword(password))
                {
                    Console.WriteLine(SqliteDataAccess.GetDecryptedPassword(password));
                    return cnn.ExecuteScalar<int>("SELECT * FROM User Where Username = '" + user + "'") > 0;
                }
                else
                    return false;
            }
        }

        private static string GetDecryptedPassword(string user = "")
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("SELECT * FROM User WHERE Username = '"+user+"'", new DynamicParameters());
                List<UserModel> listUser = output.ToList();
                UserModel userModel;
                string password = "";
                if (listUser.Count > 0)
                {
                    userModel = listUser[0];
                    password = EncryptPassword.Decrypt(userModel.password, "zxc123");
                }
                return password;
            }
        }

        public static List<UserModel> loadUser()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("SELECT * FROM User", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void UpdatePassword(string username, string newP)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE User SET Password = '" + newP + "' " +
                    "WHERE Username = '" + username + "'");
            }
        }

        public static void newUser(UserModel newUser)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO User (Username, Password) values (@username, @password)", newUser);
            }
        }

        public static void deleteUser(string delUser)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM User WHERE Username = '" + delUser + "'");
            }
        }

        private static string LoadConnectionString(string id="Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
