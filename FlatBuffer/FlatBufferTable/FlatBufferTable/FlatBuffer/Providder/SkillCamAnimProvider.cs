using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_SkillCamAnimProvider
    {
        private static FB_SkillCamAnimProvider _Instance;
        public static FB_SkillCamAnimProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_SkillCamAnimProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/SkillCamAnim.txt";
        protected Dictionary<int, FB_SkillCamAnim> mData = new Dictionary<int, FB_SkillCamAnim>();
        private List<FB_SkillCamAnim> mListData = new List<FB_SkillCamAnim>();
        public List<FB_SkillCamAnim> ListData
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
        public FB_SkillCamAnim GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_SkillCamAnim);
        }
        public Dictionary<int, FB_SkillCamAnim> GetData()
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
            if (!FB_SkillCamAnimContainer.FB_SkillCamAnimContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_SkillCamAnimContainer.GetRootAsFB_SkillCamAnimContainer(bb);
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
