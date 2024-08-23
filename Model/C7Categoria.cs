using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_Financeiro_Pessoal.Model
{
    public class C7Categoria
    {
        [Key]
        public int C7Id { get; set; }
        public required string C7Nome { get; set; }
        public required int C7Tipo_Categoria { get; set; }
        [ForeignKey("C1Usuario")]
        public int? C7FKC1ID_Usuario { get; set; }
        public C1Usuario? C1Usuario { get; set; }
    }
}