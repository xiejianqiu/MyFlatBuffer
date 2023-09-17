using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PropertyIntroProvider
    {
        private static FB_PropertyIntroProvider _Instance;
        public static FB_PropertyIntroProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PropertyIntroProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/PropertyIntro.txt";
        protected Dictionary<int, FB_PropertyIntro> mData = new Dictionary<int, FB_PropertyIntro>();
        private List<FB_PropertyIntro> mListData = new List<FB_PropertyIntro>();
        public List<FB_PropertyIntro> ListData
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
        public FB_PropertyIntro GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PropertyIntro);
        }
        public Dictionary<int, FB_PropertyIntro> GetData()
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
            if (!FB_PropertyIntroContainer.FB_PropertyIntroContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PropertyIntroContainer.GetRootAsFB_PropertyIntroContainer(bb);
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
