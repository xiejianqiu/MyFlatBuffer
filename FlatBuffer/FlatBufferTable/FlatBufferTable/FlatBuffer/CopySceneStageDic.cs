// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CopySceneStageDic : Table {
  public static FB_CopySceneStageDic GetRootAsFB_CopySceneStageDic(ByteBuffer _bb) { return GetRootAsFB_CopySceneStageDic(_bb, new FB_CopySceneStageDic()); }
  public static FB_CopySceneStageDic GetRootAsFB_CopySceneStageDic(ByteBuffer _bb, FB_CopySceneStageDic obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CopySceneStageDic __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StageDic { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StageTip { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DicNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Tips1Num { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Titils { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetTipNumIDList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TipNumIDListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int IconId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DicInfoId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PlayStrDic { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_CopySceneStageDic> CreateFB_CopySceneStageDic(FlatBufferBuilder builder,
      int ID = 0,
      int StageDic = -1,
      int StageTip = -1,
      int DicNum = 0,
      int Tips1Num = 0,
      StringOffset Titils = default(StringOffset),
      VectorOffset TipNumIDList = default(VectorOffset),
      int IconId = -1,
      int DicInfoId = -1,
      int PlayStrDic = -1) {
    builder.StartObject(10);
    FB_CopySceneStageDic.AddPlayStrDic(builder, PlayStrDic);
    FB_CopySceneStageDic.AddDicInfoId(builder, DicInfoId);
    FB_CopySceneStageDic.AddIconId(builder, IconId);
    FB_CopySceneStageDic.AddTipNumIDList(builder, TipNumIDList);
    FB_CopySceneStageDic.AddTitils(builder, Titils);
    FB_CopySceneStageDic.AddTips1Num(builder, Tips1Num);
    FB_CopySceneStageDic.AddDicNum(builder, DicNum);
    FB_CopySceneStageDic.AddStageTip(builder, StageTip);
    FB_CopySceneStageDic.AddStageDic(builder, StageDic);
    FB_CopySceneStageDic.AddID(builder, ID);
    return FB_CopySceneStageDic.EndFB_CopySceneStageDic(builder);
  }

  public static void StartFB_CopySceneStageDic(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddStageDic(FlatBufferBuilder builder, int StageDic) { builder.AddInt(1, StageDic, -1); }
  public static void AddStageTip(FlatBufferBuilder builder, int StageTip) { builder.AddInt(2, StageTip, -1); }
  public static void AddDicNum(FlatBufferBuilder builder, int DicNum) { builder.AddInt(3, DicNum, 0); }
  public static void AddTips1Num(FlatBufferBuilder builder, int Tips1Num) { builder.AddInt(4, Tips1Num, 0); }
  public static void AddTitils(FlatBufferBuilder builder, StringOffset TitilsOffset) { builder.AddOffset(5, TitilsOffset.Value, 0); }
  public static void AddTipNumIDList(FlatBufferBuilder builder, VectorOffset TipNumIDListOffset) { builder.AddOffset(6, TipNumIDListOffset.Value, 0); }
  public static VectorOffset CreateTipNumIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTipNumIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIconId(FlatBufferBuilder builder, int IconId) { builder.AddInt(7, IconId, -1); }
  public static void AddDicInfoId(FlatBufferBuilder builder, int DicInfoId) { builder.AddInt(8, DicInfoId, -1); }
  public static void AddPlayStrDic(FlatBufferBuilder builder, int PlayStrDic) { builder.AddInt(9, PlayStrDic, -1); }
  public static Offset<FB_CopySceneStageDic> EndFB_CopySceneStageDic(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CopySceneStageDic>(o);
  }
};

public sealed class FB_CopySceneStageDicContainer : Table {
  public static FB_CopySceneStageDicContainer GetRootAsFB_CopySceneStageDicContainer(ByteBuffer _bb) { return GetRootAsFB_CopySceneStageDicContainer(_bb, new FB_CopySceneStageDicContainer()); }
  public static FB_CopySceneStageDicContainer GetRootAsFB_CopySceneStageDicContainer(ByteBuffer _bb, FB_CopySceneStageDicContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CopySceneStageDicContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CopySceneStageDicContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CopySceneStageDic GetItems(int j) { return GetItems(new FB_CopySceneStageDic(), j); }
  public FB_CopySceneStageDic GetItems(FB_CopySceneStageDic obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CopySceneStageDicContainer> CreateFB_CopySceneStageDicContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CopySceneStageDicContainer.AddItems(builder, items);
    return FB_CopySceneStageDicContainer.EndFB_CopySceneStageDicContainer(builder);
  }

  public static void StartFB_CopySceneStageDicContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CopySceneStageDic>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CopySceneStageDicContainer> EndFB_CopySceneStageDicContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CopySceneStageDicContainer>(o);
  }
  public static void FinishFB_CopySceneStageDicContainerBuffer(FlatBufferBuilder builder, Offset<FB_CopySceneStageDicContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
