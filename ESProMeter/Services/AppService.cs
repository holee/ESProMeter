using ESProMeter.DataAccess;
using ESProMeter.Repository;
namespace ESProMeter.Services
{
    public class AppService
    {
        private static SqlAccess sqlAccess = null;
        public static SqlAccess SqlGetInstance
        {
            get
            {
                if (sqlAccess == null)
                {
                    sqlAccess = new SqlAccess(ConnectionService.ConnectionString());
                }
                return sqlAccess;
            }

        }

        /// <summary>
        /// Create Address Instance
        /// </summary>
        private static AddressRepository addressRepository;
        public static AddressRepository AddressGetInstance
        {
            get
            {
                if(addressRepository == null)
                {
                    addressRepository = new AddressRepository();
                }
                return addressRepository;
            }
        }

        /// <summary>
        /// Create Site Instance
        /// </summary>

        private static SiteRepository siteRepository;

        public static SiteRepository SiteGetInstance
        {
            get
            {
                if(siteRepository == null)
                {
                    siteRepository = new SiteRepository();
                }
                return siteRepository;
            }
        }

        /// <summary>
        /// Create Uom Instance
        /// </summary>
        private static UomRepository _uomRepository = null;

        public static UomRepository UomGetInstance
        {
            get
            {
                if (_uomRepository == null)
                {
                    _uomRepository = new UomRepository();
                }
                return _uomRepository;
            }
        }


        /// <summary>
        /// Create Boq instance
        /// </summary>
        private static BoqItemLineRepository boq=null;

        public static BoqItemLineRepository GetBoqItemLineInstance
        {
            get
            {
                if (boq == null)
                {
                    boq = new BoqItemLineRepository();
                }
                return boq;
            }
        }

        /// <summary>
        /// Create User instance
        /// </summary>
        private static UserRepository userRepository = null;

        public static UserRepository GetUserInstance
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository();
                }

                return userRepository;
            }
        }

        /// <summary>
        /// Name
        /// </summary>
        private static CustomerRepository customerRepository = null;
        public static CustomerRepository CustomerInstance
        {
            get
            {
                if(customerRepository == null)
                {
                    customerRepository = new CustomerRepository();
                }
                return customerRepository;
            }
        }
        /// <summary>
        /// Name
        /// </summary>
        private static NameRepository nameRepository = null;
        public static NameRepository GetNameInstance 
        {
            get
            {
                if (nameRepository == null)
                {
                    nameRepository = new NameRepository();
                }
                return nameRepository;
            }
        }
        //

        private static ItemRepository itemRepository = null;
        public static ItemRepository GetItemInstance 
        {
            get
            {
                if (itemRepository == null)
                {
                    itemRepository = new ItemRepository();
                }
                return itemRepository;
            }
        }
        /// <summary>
        /// 
        /// </summary>

        private static CompanyRepository companyRepository = null;
        public static CompanyRepository GetCompanyInstance
        {
            get
            {
                if (companyRepository == null)
                {
                    companyRepository = new CompanyRepository();
                }
                return companyRepository;
            }
        }

        /// <summary>
        /// 
        /// </summary>

        private static BoqRepository boqRepository = null;
        public static BoqRepository GetBoqInstance
        {
            get
            {
                if (boqRepository == null)
                {
                    boqRepository = new BoqRepository();
                }
                return boqRepository;
            }
        }

        private static ActivityRepository activityRepository;
        public static ActivityRepository GetActivityInstance
        {
            get
            {
                if (activityRepository == null)
                {
                    activityRepository = new ActivityRepository();
                }
                return activityRepository;
            }
        }

        private static QuoteRepository quoteRepository;
        public static QuoteRepository GetQuoteInstance
        {
            get
            {
                if (quoteRepository == null)
                {
                    quoteRepository = new QuoteRepository();
                }
                return quoteRepository;
            }
        }
    }
}
