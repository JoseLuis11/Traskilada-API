using Microsoft.EntityFrameworkCore;
using TraskiladaWebAPI.Models;
using TraskiladaWebAPI.Repositories;

namespace TraskiladaWebAPI.Context
{
    public class TraskiladaContext : DbContext
    {

        #region Private Repositories
        private IGenericRepository<User> _userRepository;
        private IGenericRepository<Appointment> _appointmentRepository;
        private IGenericRepository<Review> _reviewRepository;
        private IGenericRepository<Service> _serviceRepository;
        private IGenericRepository<WorkPlace> _workPlaceRepository;
        private IAccountRepository _accountRepository;
        #endregion

        public TraskiladaContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreatedAsync();
        }

        #region Public Repositories
        public IGenericRepository<User> UserRepository =>
            _userRepository ?? (_userRepository = new GenericRepository<User>(Users));
        public IGenericRepository<Appointment> AppointmentRespository =>
            _appointmentRepository ?? (_appointmentRepository = new GenericRepository<Appointment>(Appointments));
        public IGenericRepository<Review> ReviewRepository =>
            _reviewRepository ?? (_reviewRepository = new GenericRepository<Review>(Reviews));
        public IGenericRepository<Service> ServiceRepository =>
            _serviceRepository ?? (_serviceRepository = new GenericRepository<Service>(Services));
        public IGenericRepository<WorkPlace> WorkPlaceRepository =>
            _workPlaceRepository ?? (_workPlaceRepository = new GenericRepository<WorkPlace>(WorkPlaces));
        public IAccountRepository AccountRepository => _accountRepository ?? (_accountRepository = new AccountRepository(Accounts));
        #endregion

        #region DbSets
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkPlace> WorkPlaces { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}