using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoice.Contracts
{
    public interface IIndexed
    {
        int Index { get; }

    }

    public interface ICompanyName : IIndexed
    {
        string Name { get; }
    }

    public interface IEIK : IIndexed
    {
        string EIK { get; }
    }

    public interface ITaxNumber : IIndexed
    {
        string TaxNumber { get; }
    }

    public interface IPerson : IIndexed
    {
        string FirstName { get; }
        string MiddleName { get; }
        string LastName { get; }
        string EGN { get; }
        string Position { get; }
    }

    public interface ICity : IIndexed
    {
        string Name { get; }
    }

    public interface IAddressType
    {
        string StreetAddress { get; }
        ICity City { get; }
        string ZIP { get; }
    }

    public interface ICompany
    {
        ICompanyName Name { get; }
        IEIK EIK { get; }
        ITaxNumber TaxNumber { get; }
        ICollection<IPerson> MOLs { get; }
        IAddressType Address { get; }
        string Phone { get; }
        string EMail { get; }
    }

    public interface IGoodsName : IIndexed
    {
        string Reference { get; }
        string Name { get; }
    }

    public interface IMeasuringUnit : IIndexed
    {
        string UnitName { get; }
    }

    public interface IInvoiceRow : IIndexed
    {
        IGoodsName Product { get; }
        IMeasuringUnit Unit { get; }
        decimal Quantity { get; }
        decimal UnitPrice { get; }
        decimal Price { get; }
        decimal VAT { get; }
        decimal TotalRowPrice { get; }
    }

    public interface IBank : IIndexed
    {
        string Name { get; }
        string BIC { get; }
    }

    public interface IBankAccounType : IIndexed
    {
        string IBAN { get; }
        IBank Bank { get; }
    }

    public interface IPayment : IIndexed
    {
        string Description { get; }
    }

    public interface IInvoiceType : IIndexed
    {
        string Type { get; }
    }

    public interface IInvoice : IIndexed
    {
        ICompany Seller { get; }
        ICompany Buyer { get;}
        String Number { get; }
        IInvoiceType Type { get; }
        DateTime InvoiceDate { get; }
        DateTime TaxDate { get; }
        ICollection<IInvoiceRow> Rows { get; }
        decimal TotalWithoutVAT { get; }
        decimal VAT { get; }
        decimal TotalVAT { get;  }
        decimal TotalWithVAT { get; }
        string Say { get; }
        ICompanyName IssuingPerson { get; }
        ICompanyName ReceivingPerson { get; }
        ICity TaxPlace { get; }
        string Authority { get; }
        string Explanation { get; }
        IPayment Payment { get; }
    }
}

