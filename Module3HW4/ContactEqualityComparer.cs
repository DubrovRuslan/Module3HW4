using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Module3HW4
{
    public class ContactEqualityComparer : IEqualityComparer<Contact>
    {
        public bool Equals(Contact x, Contact y)
        {
            if (x.FullName.Equals(y.FullName) && x.Number.Equals(y.Number))
            {
                return true;
            }

            return false;
        }

        public int GetHashCode([DisallowNull] Contact obj)
        {
            var hashFullName = obj.FullName == null ? 0 : obj.FullName.GetHashCode();
            var hashNumber = obj.Number == null ? 0 : obj.Number.GetHashCode();
            return hashFullName ^ hashNumber;
        }
    }
}
