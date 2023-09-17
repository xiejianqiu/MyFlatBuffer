using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_PlayerSkinPartProvider
    {
        private static FB_PlayerSkinPartProvider _Instance;
        public static FB_PlayerSkinPartProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_PlayerSkinPartProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/PlayerSkinPart.txt";
        protected Dictionary<int, FB_PlayerSkinPart> mData = new Dictionary<int, FB_PlayerSkinPart>();
        private List<FB_PlayerSkinPart> mListData = new List<FB_PlayerSkinPart>();
        public List<FB_PlayerSkinPart> ListData
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
        public FB_PlayerSkinPart GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_PlayerSkinPart);
        }
        public Dictionary<int, FB_PlayerSkinPart> GetData()
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
            if (!FB_PlayerSkinPartContainer.FB_PlayerSkinPartContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_PlayerSkinPartContainer.GetRootAsFB_PlayerSkinPartContainer(bb);
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
