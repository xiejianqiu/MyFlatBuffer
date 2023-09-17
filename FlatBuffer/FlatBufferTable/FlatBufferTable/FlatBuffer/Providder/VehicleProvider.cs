using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_VehicleProvider
    {
        private static FB_VehicleProvider _Instance;
        public static FB_VehicleProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_VehicleProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/Vehicle.txt";
        protected Dictionary<int, FB_Vehicle> mData = new Dictionary<int, FB_Vehicle>();
        private List<FB_Vehicle> mListData = new List<FB_Vehicle>();
        public List<FB_Vehicle> ListData
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
        public FB_Vehicle GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_Vehicle);
        }
        public Dictionary<int, FB_Vehicle> GetData()
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
            if (!FB_VehicleContainer.FB_VehicleContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_VehicleContainer.GetRootAsFB_VehicleContainer(bb);
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
