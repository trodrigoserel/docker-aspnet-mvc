using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc1.Models
{
    public interface IRepository
    {
        IEnumerable<Produto> Produtos { get; }
    }
}