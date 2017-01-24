using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoice.Contracts
{
    interface ICommonDatabase
    {
        ICollection<IIndexed> DatabaseCollection { get; }
        void AddElement();
        void RemoveElement();
        void GetFromFile();
        void SaveToFile();
        IIndexed GetElementByIndex(int index);

    }

    interface IInvoiceDatabase : ICommonDatabase
    {
        
    }
}
