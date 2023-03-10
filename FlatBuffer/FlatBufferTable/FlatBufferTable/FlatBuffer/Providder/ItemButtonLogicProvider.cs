using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ItemButtonLogicProvider
    {
        private static FB_ItemButtonLogicProvider _Instance;
        public static FB_ItemButtonLogicProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ItemButtonLogicProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/ItemButtonLogic.txt";
        protected Dictionary<int, FB_ItemButtonLogic> mData = new Dictionary<int, FB_ItemButtonLogic>();
        private List<FB_ItemButtonLogic> mListData = new List<FB_ItemButtonLogic>();
        public List<FB_ItemButtonLogic> ListData
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
        public FB_ItemButtonLogic GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ItemButtonLogic);
        }
        public Dictionary<int, FB_ItemButtonLogic> GetData()
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
            if (!FB_ItemButtonLogicContainer.FB_ItemButtonLogicContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ItemButtonLogicContainer.GetRootAsFB_ItemButtonLogicContainer(bb);
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
