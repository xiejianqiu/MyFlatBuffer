using System;
using FlatBuffers;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Profiling;
namespace Shark
{
    public class FB_ChatWordExpressionProvider
    {
        private static FB_ChatWordExpressionProvider _Instance;
        public static FB_ChatWordExpressionProvider Instance {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new FB_ChatWordExpressionProvider();
                }
                return _Instance;
            }
        }
        public string tableRPath = "Client/ChatWordExpression.txt";
        protected Dictionary<int, FB_ChatWordExpression> mData = new Dictionary<int, FB_ChatWordExpression>();
        private List<FB_ChatWordExpression> mListData = new List<FB_ChatWordExpression>();
        public List<FB_ChatWordExpression> ListData
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
        public FB_ChatWordExpression GetDataById(int id)
        {
            if (mData.ContainsKey(id))
                return mData[id];
            return default(FB_ChatWordExpression);
        }
        public Dictionary<int, FB_ChatWordExpression> GetData()
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
            if (!FB_ChatWordExpressionContainer.FB_ChatWordExpressionContainerBufferHasIdentifier(bb))
            {
                throw new Exception("Identifier test failed, you sure the identifier is identical to the generated schema's one?");
            }
            var data = FB_ChatWordExpressionContainer.GetRootAsFB_ChatWordExpressionContainer(bb);
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
