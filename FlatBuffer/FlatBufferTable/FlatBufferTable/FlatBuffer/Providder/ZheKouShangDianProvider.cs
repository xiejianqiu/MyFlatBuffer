using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ZheKouShangDianProvider
    {
        private static FB_ZheKouShangDianProvider _Instance;
        public static FB_ZheKouShangDianProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ZheKouShangDianProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ZheKouShangDian.txt";
        protected Dictionary<int, FB_ZheKouShangDian> mData = new Dictionary<int, FB_ZheKouShangDian>();
        private List<FB_ZheKouShangDian> mListData = new List<FB_ZheKouShangDian>();
        public List<FB_ZheKouShangDian> ListData
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
        public FB_ZheKouShangDian GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ZheKouShangDian);
        }
        public Dictionary<int, FB_ZheKouShangDian> GetData()
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
            if (!FB_ZheKouShangDianContainer.FB_ZheKouShangDianContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ZheKouShangDianContainer.GetRootAsFB_ZheKouShangDianContainer(bb);
            for (int index = 0; index < data.ItemsLength; index++)
            {
                var item = data.GetItems(index);
                mData.Add(item.ID, item);
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
