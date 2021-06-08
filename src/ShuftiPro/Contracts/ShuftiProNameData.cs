using System.Linq;
using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProNameData : IShuftiProNameData
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get => !string.IsNullOrEmpty(MiddleName) ?
                $"{FirstName} {MiddleName} {LastName}" : $"{FirstName} {LastName}";
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    return;
                }
                var name = value.Split(' ');
                FirstName = name.FirstOrDefault();
                LastName = name.LastOrDefault();
                if (name.Length > 2)
                {
                    MiddleName = name[1];
                }
            }
        }
    }
}
