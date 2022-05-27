using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{

    public class HashMap
    {
        private readonly HashEntry[] _buckets;
        public HashMap(int size)
        {
            _buckets = new HashEntry[size];
        }
        public void Add(string key, object item)
        {
            ValidateKey(key);

            var valueNode = new HashEntry { Anahtar = key, Deger = item, Next = null };
            int position = GetBucketByKey(key);
            HashEntry listNode = _buckets[position];

            if (null== listNode)
            {
                _buckets[position] = valueNode;
            }
            else
            {
                while (null != listNode.Next)
                {
                    listNode = listNode.Next;
                }
                listNode.Next = valueNode;
            }
        }
        public object Get(string key)
        {
            ValidateKey(key);

            var (_, node) = GetNodeByKey(key);
            if (node == null) throw
                       new ArgumentOutOfRangeException(nameof(key), $"The key '{key}' is not found");
            return node.Deger;
        }
        public bool Remove(string key)
        {
            ValidateKey(key);
            int position = GetBucketByKey(key);

            var (previous, current) = GetNodeByKey(key);
            if (null == current) return false;
            if (null == previous)
            {
                _buckets[position] = null;
                return true;
            }
            previous.Next = current.Next;
            return true;
        }
        public bool ContainsKey(string key)
        {
            ValidateKey(key);

            var (_, node) = GetNodeByKey(key);
            return null != node;
        }
        public int GetBucketByKey(string key)
        {
            return key[0] % _buckets.Length;
        }
        protected (HashEntry previous, HashEntry current) GetNodeByKey(string key)
        {
            int position = GetBucketByKey(key);
            HashEntry listNode = _buckets[position];
            HashEntry previous = null;

            while (null!= listNode)
            {
                if (listNode.Anahtar == key) return (previous, listNode);

                previous = listNode;
                listNode = listNode.Next;
            }
            return (null, null);
        }
        
        protected void ValidateKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));
        }
    }

}
