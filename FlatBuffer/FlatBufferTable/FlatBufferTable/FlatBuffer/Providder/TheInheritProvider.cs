using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TheInheritProvider
    {
        private static FB_TheInheritProvider _Instance;
        public static FB_TheInheritProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TheInheritProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TheInherit.txt";
        protected Dictionary<int, FB_TheInherit> mData = new Dictionary<int, FB_TheInherit>();
        private List<FB_TheInherit> mListData = new List<FB_TheInherit>();
        public List<FB_TheInherit> ListData
        {
            get
            {
                var id = this.GetHashCode();
                if (mListData.Count <= 0)
                {
                    mListData.AddRange(mData.Values);
                }
                return mListData;
            }
        }
        public FB_TheInherit GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TheInherit);
        }
        public Dictionary<int, FB_TheInherit> GetData()
        {
            return mData;
        }
        public void LoadFromFile(string dataPath)
        {
            this.LoadData(new ByteBuffer(File.ReadAllBytes(dataPath)));
        }
        public void LoadFromMemory(byte[] dataBytes)
        {
            this.LoadData(new ByteBuffer(dataBytes));
        }
        public void LoadData(ByteBuffer bb) {
            if (!FB_TheInheritContainer.FB_TheInheritContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TheInheritContainer.GetRootAsFB_TheInheritContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.Id, item);
            }
            var id = this.GetHashCode();
        }
        public void Clear()
        {
            mData.Clear();
            mListData.Clear();
        }
    }
}
