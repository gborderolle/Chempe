using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Chempe
{
    /// <summary>
    /// Naturaleza de los documentos: cédula de identidad, contratos firmados, factura de compra del bien, garantía del bien, etc.
    /// </summary>
    [Table("List_documents_type")]
    public class List_documents_type
    {
        [Key]
        public int List_documents_type_ID { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }

        public List_documents_type()
        {
        }
        public List_documents_type(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
