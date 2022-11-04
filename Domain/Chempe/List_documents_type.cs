using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Chempe
{
    /// <summary>
    /// Naturaleza de los documentos: cédula de identidad, contratos firmados, factura de compra del bien, garantía del bien, etc.
    /// </summary>
    public class List_documents_type
    {
        [Key]
        public int List_documents_type_ID { get; set; }
        public string Name { get; set; }

    }
}
