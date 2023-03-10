// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenYuRankBase : Table {
  public static FB_ShenYuRankBase GetRootAsFB_ShenYuRankBase(ByteBuffer _bb) { return GetRootAsFB_ShenYuRankBase(_bb, new FB_ShenYuRankBase()); }
  public static FB_ShenYuRankBase GetRootAsFB_ShenYuRankBase(ByteBuffer _bb, FB_ShenYuRankBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenYuRankBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string GetTitleList(int j) { int o = __offset(8); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int TitleListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int ShowNum { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int RankPage { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }

  public static Offset<FB_ShenYuRankBase> CreateFB_ShenYuRankBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset TitleList = default(VectorOffset),
      int ShowNum = 1,
      int RankPage = 1) {
    builder.StartObject(5);
    FB_ShenYuRankBase.AddRankPage(builder, RankPage);
    FB_ShenYuRankBase.AddShowNum(builder, ShowNum);
    FB_ShenYuRankBase.AddTitleList(builder, TitleList);
    FB_ShenYuRankBase.AddName(builder, Name);
    FB_ShenYuRankBase.AddID(builder, ID);
    return FB_ShenYuRankBase.EndFB_ShenYuRankBase(builder);
  }

  public static void StartFB_ShenYuRankBase(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddTitleList(FlatBufferBuilder builder, VectorOffset TitleListOffset) { builder.AddOffset(2, TitleListOffset.Value, 0); }
  public static VectorOffset CreateTitleListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartTitleListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShowNum(FlatBufferBuilder builder, int ShowNum) { builder.AddInt(3, ShowNum, 1); }
  public static void AddRankPage(FlatBufferBuilder builder, int RankPage) { builder.AddInt(4, RankPage, 1); }
  public static Offset<FB_ShenYuRankBase> EndFB_ShenYuRankBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenYuRankBase>(o);
  }
};

public sealed class FB_ShenYuRankBaseContainer : Table {
  public static FB_ShenYuRankBaseContainer GetRootAsFB_ShenYuRankBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ShenYuRankBaseContainer(_bb, new FB_ShenYuRankBaseContainer()); }
  public static FB_ShenYuRankBaseContainer GetRootAsFB_ShenYuRankBaseContainer(ByteBuffer _bb, FB_ShenYuRankBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenYuRankBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenYuRankBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenYuRankBase GetItems(int j) { return GetItems(new FB_ShenYuRankBase(), j); }
  public FB_ShenYuRankBase GetItems(FB_ShenYuRankBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenYuRankBaseContainer> CreateFB_ShenYuRankBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenYuRankBaseContainer.AddItems(builder, items);
    return FB_ShenYuRankBaseContainer.EndFB_ShenYuRankBaseContainer(builder);
  }

  public static void StartFB_ShenYuRankBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenYuRankBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenYuRankBaseContainer> EndFB_ShenYuRankBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenYuRankBaseContainer>(o);
  }
  public static void FinishFB_ShenYuRankBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenYuRankBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
