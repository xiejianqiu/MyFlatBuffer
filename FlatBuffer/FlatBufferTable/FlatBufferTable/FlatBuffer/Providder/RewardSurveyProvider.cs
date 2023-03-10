using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_RewardSurveyProvider
    {
        private static FB_RewardSurveyProvider _Instance;
        public static FB_RewardSurveyProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_RewardSurveyProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Public/RewardSurvey.txt";
        protected Dictionary<int, FB_RewardSurvey> mData = new Dictionary<int, FB_RewardSurvey>();
        private List<FB_RewardSurvey> mListData = new List<FB_RewardSurvey>();
        public List<FB_RewardSurvey> ListData
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
        public FB_RewardSurvey GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_RewardSurvey);
        }
        public Dictionary<int, FB_RewardSurvey> GetData()
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
            if (!FB_RewardSurveyContainer.FB_RewardSurveyContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_RewardSurveyContainer.GetRootAsFB_RewardSurveyContainer(bb);
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
