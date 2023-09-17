// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MarryBaseInfo : Table {
  public static FB_MarryBaseInfo GetRootAsFB_MarryBaseInfo(ByteBuffer _bb) { return GetRootAsFB_MarryBaseInfo(_bb, new FB_MarryBaseInfo()); }
  public static FB_MarryBaseInfo GetRootAsFB_MarryBaseInfo(ByteBuffer _bb, FB_MarryBaseInfo obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MarryBaseInfo __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GoldType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GoldNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ShoutStrId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool HaveHunLi { get { int o = __offset(12); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int ItemId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemNum { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetFirstMenPaiItemIdList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FirstMenPaiItemIdListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int FirstItemNum { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetSecondMenPaiItemIdList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SecondMenPaiItemIdListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int SecondItemNum { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MailId { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_MarryBaseInfo> CreateFB_MarryBaseInfo(FlatBufferBuilder builder,
      int ID = 0,
      int GoldType = 0,
      int GoldNum = 0,
      int ShoutStrId = 0,
      bool HaveHunLi = false,
      int ItemId = 0,
      int ItemNum = 0,
      VectorOffset FirstMenPaiItemIdList = default(VectorOffset),
      int FirstItemNum = 0,
      VectorOffset SecondMenPaiItemIdList = default(VectorOffset),
      int SecondItemNum = 0,
      int MailId = 0) {
    builder.StartObject(12);
    FB_MarryBaseInfo.AddMailId(builder, MailId);
    FB_MarryBaseInfo.AddSecondItemNum(builder, SecondItemNum);
    FB_MarryBaseInfo.AddSecondMenPaiItemIdList(builder, SecondMenPaiItemIdList);
    FB_MarryBaseInfo.AddFirstItemNum(builder, FirstItemNum);
    FB_MarryBaseInfo.AddFirstMenPaiItemIdList(builder, FirstMenPaiItemIdList);
    FB_MarryBaseInfo.AddItemNum(builder, ItemNum);
    FB_MarryBaseInfo.AddItemId(builder, ItemId);
    FB_MarryBaseInfo.AddShoutStrId(builder, ShoutStrId);
    FB_MarryBaseInfo.AddGoldNum(builder, GoldNum);
    FB_MarryBaseInfo.AddGoldType(builder, GoldType);
    FB_MarryBaseInfo.AddID(builder, ID);
    FB_MarryBaseInfo.AddHaveHunLi(builder, HaveHunLi);
    return FB_MarryBaseInfo.EndFB_MarryBaseInfo(builder);
  }

  public static void StartFB_MarryBaseInfo(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddGoldType(FlatBufferBuilder builder, int GoldType) { builder.AddInt(1, GoldType, 0); }
  public static void AddGoldNum(FlatBufferBuilder builder, int GoldNum) { builder.AddInt(2, GoldNum, 0); }
  public static void AddShoutStrId(FlatBufferBuilder builder, int ShoutStrId) { builder.AddInt(3, ShoutStrId, 0); }
  public static void AddHaveHunLi(FlatBufferBuilder builder, bool HaveHunLi) { builder.AddBool(4, HaveHunLi, false); }
  public static void AddItemId(FlatBufferBuilder builder, int ItemId) { builder.AddInt(5, ItemId, 0); }
  public static void AddItemNum(FlatBufferBuilder builder, int ItemNum) { builder.AddInt(6, ItemNum, 0); }
  public static void AddFirstMenPaiItemIdList(FlatBufferBuilder builder, VectorOffset FirstMenPaiItemIdListOffset) { builder.AddOffset(7, FirstMenPaiItemIdListOffset.Value, 0); }
  public static VectorOffset CreateFirstMenPaiItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFirstMenPaiItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFirstItemNum(FlatBufferBuilder builder, int FirstItemNum) { builder.AddInt(8, FirstItemNum, 0); }
  public static void AddSecondMenPaiItemIdList(FlatBufferBuilder builder, VectorOffset SecondMenPaiItemIdListOffset) { builder.AddOffset(9, SecondMenPaiItemIdListOffset.Value, 0); }
  public static VectorOffset CreateSecondMenPaiItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSecondMenPaiItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSecondItemNum(FlatBufferBuilder builder, int SecondItemNum) { builder.AddInt(10, SecondItemNum, 0); }
  public static void AddMailId(FlatBufferBuilder builder, int MailId) { builder.AddInt(11, MailId, 0); }
  public static Offset<FB_MarryBaseInfo> EndFB_MarryBaseInfo(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryBaseInfo>(o);
  }
};

public sealed class FB_MarryBaseInfoContainer : Table {
  public static FB_MarryBaseInfoContainer GetRootAsFB_MarryBaseInfoContainer(ByteBuffer _bb) { return GetRootAsFB_MarryBaseInfoContainer(_bb, new FB_MarryBaseInfoContainer()); }
  public static FB_MarryBaseInfoContainer GetRootAsFB_MarryBaseInfoContainer(ByteBuffer _bb, FB_MarryBaseInfoContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MarryBaseInfoContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MarryBaseInfoContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MarryBaseInfo GetItems(int j) { return GetItems(new FB_MarryBaseInfo(), j); }
  public FB_MarryBaseInfo GetItems(FB_MarryBaseInfo obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MarryBaseInfoContainer> CreateFB_MarryBaseInfoContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MarryBaseInfoContainer.AddItems(builder, items);
    return FB_MarryBaseInfoContainer.EndFB_MarryBaseInfoContainer(builder);
  }

  public static void StartFB_MarryBaseInfoContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MarryBaseInfo>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MarryBaseInfoContainer> EndFB_MarryBaseInfoContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MarryBaseInfoContainer>(o);
  }
  public static void FinishFB_MarryBaseInfoContainerBuffer(FlatBufferBuilder builder, Offset<FB_MarryBaseInfoContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
