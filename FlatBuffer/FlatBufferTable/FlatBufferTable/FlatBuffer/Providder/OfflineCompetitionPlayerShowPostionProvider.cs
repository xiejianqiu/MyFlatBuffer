using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_OfflineCompetitionPlayerShowPostionProvider
    {
        private static FB_OfflineCompetitionPlayerShowPostionProvider _Instance;
        public static FB_OfflineCompetitionPlayerShowPostionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_OfflineCompetitionPlayerShowPostionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/OfflineCompetitionPlayerShowPostion.txt";
        protected Dictionary<int, FB_OfflineCompetitionPlayerShowPostion> mData = new Dictionary<int, FB_OfflineCompetitionPlayerShowPostion>();
        private List<FB_OfflineCompetitionPlayerShowPostion> mListData = new List<FB_OfflineCompetitionPlayerShowPostion>();
        public List<FB_OfflineCompetitionPlayerShowPostion> ListData
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
        public FB_OfflineCompetitionPlayerShowPostion GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_OfflineCompetitionPlayerShowPostion);
        }
        public Dictionary<int, FB_OfflineCompetitionPlayerShowPostion> GetData()
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
            if (!FB_OfflineCompetitionPlayerShowPostionContainer.FB_OfflineCompetitionPlayerShowPostionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_OfflineCompetitionPlayerShowPostionContainer.GetRootAsFB_OfflineCompetitionPlayerShowPostionContainer(bb);
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
