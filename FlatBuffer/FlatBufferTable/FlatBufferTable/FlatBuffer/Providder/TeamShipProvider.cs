using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_TeamShipProvider
    {
        private static FB_TeamShipProvider _Instance;
        public static FB_TeamShipProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_TeamShipProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/TeamShip.txt";
        protected Dictionary<int, FB_TeamShip> mData = new Dictionary<int, FB_TeamShip>();
        private List<FB_TeamShip> mListData = new List<FB_TeamShip>();
        public List<FB_TeamShip> ListData
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
        public FB_TeamShip GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_TeamShip);
        }
        public Dictionary<int, FB_TeamShip> GetData()
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
            if (!FB_TeamShipContainer.FB_TeamShipContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_TeamShipContainer.GetRootAsFB_TeamShipContainer(bb);
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
