using System.ComponentModel.DataAnnotations;

namespace WpfXamel.Modelos
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }

        [StringLength(50)]
        public string  Nombre { get; set; }
    }
}
