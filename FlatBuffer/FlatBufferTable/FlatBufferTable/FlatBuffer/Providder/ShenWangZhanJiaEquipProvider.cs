using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ShenWangZhanJiaEquipProvider
    {
        private static FB_ShenWangZhanJiaEquipProvider _Instance;
        public static FB_ShenWangZhanJiaEquipProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ShenWangZhanJiaEquipProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/ShenWangZhanJiaEquip.txt";
        protected Dictionary<int, FB_ShenWangZhanJiaEquip> mData = new Dictionary<int, FB_ShenWangZhanJiaEquip>();
        private List<FB_ShenWangZhanJiaEquip> mListData = new List<FB_ShenWangZhanJiaEquip>();
        public List<FB_ShenWangZhanJiaEquip> ListData
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
        public FB_ShenWangZhanJiaEquip GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ShenWangZhanJiaEquip);
        }
        public Dictionary<int, FB_ShenWangZhanJiaEquip> GetData()
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
            if (!FB_ShenWangZhanJiaEquipContainer.FB_ShenWangZhanJiaEquipContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ShenWangZhanJiaEquipContainer.GetRootAsFB_ShenWangZhanJiaEquipContainer(bb);
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
