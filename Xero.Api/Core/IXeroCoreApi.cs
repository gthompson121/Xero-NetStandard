using System.Collections.Generic;
using Xero.Api.Core.Endpoints;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Setup;
using Organisation = Xero.Api.Core.Model.Organisation;

namespace Xero.Api.Core
{
    public interface IXeroCoreApi
    {
        IAccountsEndpoint Accounts { get; }
        AllocationsEndpoint Allocations { get; }
        AttachmentsEndpoint Attachments { get; }
        IBankTransactionsEndpoint BankTransactions { get; }
        IBankTransfersEndpoint BankTransfers { get; }
        IBrandingThemesEndpoint BrandingThemes { get; }
        IContactsEndpoint Contacts { get; }
        IContactGroupsEndpoint ContactGroups { get; }
        ICreditNotesEndpoint CreditNotes { get; }
        ICurrenciesEndpoint Currencies { get; set; }
        IEmployeesEndpoint Employees { get; }
        IExpenseClaimsEndpoint ExpenseClaims { get; }
        IFilesEndpoint Files { get; }
        IFoldersEndpoint Folders { get; }
        IInboxEndpoint Inbox { get; }
        IInvoicesEndpoint Invoices { get; }
        IItemsEndpoint Items { get; }
        IJournalsEndpoint Journals { get; }
        ILinkedTransactionsEndpoint LinkedTransactions { get; }
        IManualJournalsEndpoint ManualJournals { get; }
        IOverpaymentsEndpoint Overpayments { get; }
        IPaymentsEndpoint Payments { get; }
        PdfEndpoint PdfFiles { get; }
        IPrepaymentsEndpoint Prepayments { get; }
        IPurchaseOrdersEndpoint PurchaseOrders { get; }
        IReceiptsEndpoint Receipts { get; }
        IRepeatingInvoicesEndpoint RepeatingInvoices { get; }
        IReportsEndpoint Reports { get; }
        SetupEndpoint Setup { get; }
        ITaxRatesEndpoint TaxRates { get; }
        ITrackingCategoriesEndpoint TrackingCategories { get; }
        IUsersEndpoint Users { get; }
        Organisation Organisation { get; }
        string BaseUri { get; }
        string UserAgent { get; set; }
        IEnumerable<Invoice> Create(IEnumerable<Invoice> items);
        IEnumerable<Contact> Create(IEnumerable<Contact> items);
        IEnumerable<Account> Create(IEnumerable<Account> items);
        IEnumerable<Employee> Create(IEnumerable<Employee> items);
        IEnumerable<ExpenseClaim> Create(IEnumerable<ExpenseClaim> items);
        IEnumerable<Receipt> Create(IEnumerable<Receipt> items);
        IEnumerable<CreditNote> Create(IEnumerable<CreditNote> items);
        IEnumerable<Item> Create(IEnumerable<Item> items);
        IEnumerable<ManualJournal> Create(IEnumerable<ManualJournal> items);
        IEnumerable<Payment> Create(IEnumerable<Payment> items);
        IEnumerable<TaxRate> Create(IEnumerable<TaxRate> items);
        IEnumerable<BankTransaction> Create(IEnumerable<BankTransaction> items);
        IEnumerable<BankTransfer> Create(IEnumerable<BankTransfer> items);
        Invoice Create(Invoice item);
        Contact Create(Contact item);
        Account Create(Account item);
        Employee Create(Employee item);
        ExpenseClaim Create(ExpenseClaim item);
        Receipt Create(Receipt item);
        CreditNote Create(CreditNote item);
        Item Create(Item item);
        ManualJournal Create(ManualJournal item);
        Payment Create(Payment item);
        TaxRate Create(TaxRate item);
        BankTransaction Create(BankTransaction item);
        BankTransfer Create(BankTransfer item);
        ImportSummary Create(Setup item);
        Invoice Update(Invoice item);
        Contact Update(Contact item);
        ContactGroup Update(ContactGroup item);
        Employee Update(Employee item);
        ExpenseClaim Update(ExpenseClaim item);
        Receipt Update(Receipt item);
        CreditNote Update(CreditNote item);
        Item Update(Item item);
        ManualJournal Update(ManualJournal item);
        BankTransaction Update(BankTransaction item);
        BankTransfer Update(BankTransfer item);
        TaxRate Update(TaxRate item);
        ImportSummary Update(Setup item);
        TrackingCategory Update(TrackingCategory item);

        void SummarizeErrors(bool summarize);
    }
}