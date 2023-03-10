using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_CharAnimProvider
    {
        private static FB_CharAnimProvider _Instance;
        public static FB_CharAnimProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_CharAnimProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/CharAnim.txt";
        protected Dictionary<int, FB_CharAnim> mData = new Dictionary<int, FB_CharAnim>();
        private List<FB_CharAnim> mListData = new List<FB_CharAnim>();
        public List<FB_CharAnim> ListData
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
        public FB_CharAnim GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_CharAnim);
        }
        public Dictionary<int, FB_CharAnim> GetData()
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
            if (!FB_CharAnimContainer.FB_CharAnimContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_CharAnimContainer.GetRootAsFB_CharAnimContainer(bb);
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
