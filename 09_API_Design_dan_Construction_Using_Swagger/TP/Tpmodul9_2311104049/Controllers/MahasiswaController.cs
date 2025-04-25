using Microsoft.AspNetCore.Mvc;
using Tpmodul9_2311104049.Models;

namespace Tpmodul9_2311104049.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>()
        {
            new Mahasiswa { Nama = "Zaenarif Putra", NIM = "2311104049" },
            new Mahasiswa { Nama = "Muhammad Shafiq Rasuna", NIM = "2311104050" },
            new Mahasiswa { Nama = "Muhammad Ihsan", NIM = "2311104051" },

        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> Get()
        {
            return daftarMahasiswa;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Mahasiswa tidak ditemukan");
            return daftarMahasiswa[index];
        }

        [HttpPost]
        public IActionResult Post([FromBody] Mahasiswa mhs)
        {
            daftarMahasiswa.Add(mhs);
            return Ok("Mahasiswa berhasil ditambahkan");
        }

        [HttpDelete("{index}")]
        public IActionResult Delete(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Index tidak valid");
            daftarMahasiswa.RemoveAt(index);
            return Ok("Mahasiswa berhasil dihapus");
        }
    }
}
