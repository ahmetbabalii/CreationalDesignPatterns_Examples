namespace Builder.school.Dtos
{
    public sealed class Subject : IEquatable<Subject>
    {
        public Subject(string name)
        {
            Name = name;
        }

        public Subject(Subject other)
        {
            if (other != null)
            {
                Name = other.Name;
            }
        }

        public string Name { get; }

        public bool Equals(Subject other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return Name == other.Name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;

            return Equals((Subject)obj);
        }

        public override int GetHashCode()
        {
            return Name != null ? Name.GetHashCode() : 0;
        }

        public static bool operator ==(Subject left, Subject right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Subject left, Subject right)
        {
            return !Equals(left, right);
        }
    }

    public static class SubjectExtensions
    {
        public static IEnumerable<Subject> Clone(this IEnumerable<Subject> subjects)
        {
            return subjects != null
                ? subjects
                  .Where(s => s != null)
                  .Select(s => new Subject(s))
                : new List<Subject>();
        }
    }
}
