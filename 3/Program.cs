using System;

class Program {
    static void Main(string[] args) {
        Dictionary<Key, string> dictionary = new Dictionary<Key, string>();
        Key firstKey = new Key(1);
        dictionary.Add(firstKey, "First");
        Key secondKey = new Key(2);
        dictionary.Add(secondKey, "Second");

        Console.WriteLine(dictionary[firstKey]);
    }
        public class Key
        {
            public int Marker { get; }
            
            public Key(int marker) => Marker = marker;
            
            public override int GetHashCode() => Marker / 10;
            
            public override bool Equals(object? other) =>
                other is Key ? other.GetHashCode() == GetHashCode() : base.Equals(other);
        }
    } 
}