// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ChapterCardBase : Table {
  public static FB_ChapterCardBase GetRootAsFB_ChapterCardBase(ByteBuffer _bb) { return GetRootAsFB_ChapterCardBase(_bb, new FB_ChapterCardBase()); }
  public static FB_ChapterCardBase GetRootAsFB_ChapterCardBase(ByteBuffer _bb, FB_ChapterCardBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ChapterCardBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string CardName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string CardDesc { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int UIModelID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int InitQuality { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ChapterID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FragmentItemID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ActiveNeedCount { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FakeObjID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ChapterCardBase> CreateFB_ChapterCardBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset CardName = default(StringOffset),
      StringOffset CardDesc = default(StringOffset),
      int UIModelID = -1,
      int InitQuality = -1,
      int ChapterID = -1,
      int FragmentItemID = -1,
      int ActiveNeedCount = -1,
      int FakeObjID = -1) {
    builder.StartObject(9);
    FB_ChapterCardBase.AddFakeObjID(builder, FakeObjID);
    FB_ChapterCardBase.AddActiveNeedCount(builder, ActiveNeedCount);
    FB_ChapterCardBase.AddFragmentItemID(builder, FragmentItemID);
    FB_ChapterCardBase.AddChapterID(builder, ChapterID);
    FB_ChapterCardBase.AddInitQuality(builder, InitQuality);
    FB_ChapterCardBase.AddUIModelID(builder, UIModelID);
    FB_ChapterCardBase.AddCardDesc(builder, CardDesc);
    FB_ChapterCardBase.AddCardName(builder, CardName);
    FB_ChapterCardBase.AddID(builder, ID);
    return FB_ChapterCardBase.EndFB_ChapterCardBase(builder);
  }

  public static void StartFB_ChapterCardBase(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCardName(FlatBufferBuilder builder, StringOffset CardNameOffset) { builder.AddOffset(1, CardNameOffset.Value, 0); }
  public static void AddCardDesc(FlatBufferBuilder builder, StringOffset CardDescOffset) { builder.AddOffset(2, CardDescOffset.Value, 0); }
  public static void AddUIModelID(FlatBufferBuilder builder, int UIModelID) { builder.AddInt(3, UIModelID, -1); }
  public static void AddInitQuality(FlatBufferBuilder builder, int InitQuality) { builder.AddInt(4, InitQuality, -1); }
  public static void AddChapterID(FlatBufferBuilder builder, int ChapterID) { builder.AddInt(5, ChapterID, -1); }
  public static void AddFragmentItemID(FlatBufferBuilder builder, int FragmentItemID) { builder.AddInt(6, FragmentItemID, -1); }
  public static void AddActiveNeedCount(FlatBufferBuilder builder, int ActiveNeedCount) { builder.AddInt(7, ActiveNeedCount, -1); }
  public static void AddFakeObjID(FlatBufferBuilder builder, int FakeObjID) { builder.AddInt(8, FakeObjID, -1); }
  public static Offset<FB_ChapterCardBase> EndFB_ChapterCardBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChapterCardBase>(o);
  }
};

public sealed class FB_ChapterCardBaseContainer : Table {
  public static FB_ChapterCardBaseContainer GetRootAsFB_ChapterCardBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ChapterCardBaseContainer(_bb, new FB_ChapterCardBaseContainer()); }
  public static FB_ChapterCardBaseContainer GetRootAsFB_ChapterCardBaseContainer(ByteBuffer _bb, FB_ChapterCardBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ChapterCardBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ChapterCardBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ChapterCardBase GetItems(int j) { return GetItems(new FB_ChapterCardBase(), j); }
  public FB_ChapterCardBase GetItems(FB_ChapterCardBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChapterCardBaseContainer> CreateFB_ChapterCardBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ChapterCardBaseContainer.AddItems(builder, items);
    return FB_ChapterCardBaseContainer.EndFB_ChapterCardBaseContainer(builder);
  }

  public static void StartFB_ChapterCardBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ChapterCardBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChapterCardBaseContainer> EndFB_ChapterCardBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChapterCardBaseContainer>(o);
  }
  public static void FinishFB_ChapterCardBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ChapterCardBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
