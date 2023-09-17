using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_DestinyBloodSkillDesProvider
    {
        private static FB_DestinyBloodSkillDesProvider _Instance;
        public static FB_DestinyBloodSkillDesProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_DestinyBloodSkillDesProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/DestinyBloodSkillDes.txt";
        protected Dictionary<int, FB_DestinyBloodSkillDes> mData = new Dictionary<int, FB_DestinyBloodSkillDes>();
        private List<FB_DestinyBloodSkillDes> mListData = new List<FB_DestinyBloodSkillDes>();
        public List<FB_DestinyBloodSkillDes> ListData
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
        public FB_DestinyBloodSkillDes GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_DestinyBloodSkillDes);
        }
        public Dictionary<int, FB_DestinyBloodSkillDes> GetData()
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
            if (!FB_DestinyBloodSkillDesContainer.FB_DestinyBloodSkillDesContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_DestinyBloodSkillDesContainer.GetRootAsFB_DestinyBloodSkillDesContainer(bb);
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
