// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiYiCard : Table {
  public static FB_JiYiCard GetRootAsFB_JiYiCard(ByteBuffer _bb) { return GetRootAsFB_JiYiCard(_bb, new FB_JiYiCard()); }
  public static FB_JiYiCard GetRootAsFB_JiYiCard(ByteBuffer _bb, FB_JiYiCard obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiYiCard __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Round { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int IconNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string GetIconList(int j) { int o = __offset(10); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int IconListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiYiCard> CreateFB_JiYiCard(FlatBufferBuilder builder,
      int Id = 0,
      int Round = 0,
      int IconNum = 0,
      VectorOffset IconList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_JiYiCard.AddIconList(builder, IconList);
    FB_JiYiCard.AddIconNum(builder, IconNum);
    FB_JiYiCard.AddRound(builder, Round);
    FB_JiYiCard.AddId(builder, Id);
    return FB_JiYiCard.EndFB_JiYiCard(builder);
  }

  public static void StartFB_JiYiCard(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddRound(FlatBufferBuilder builder, int Round) { builder.AddInt(1, Round, 0); }
  public static void AddIconNum(FlatBufferBuilder builder, int IconNum) { builder.AddInt(2, IconNum, 0); }
  public static void AddIconList(FlatBufferBuilder builder, VectorOffset IconListOffset) { builder.AddOffset(3, IconListOffset.Value, 0); }
  public static VectorOffset CreateIconListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartIconListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiYiCard> EndFB_JiYiCard(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiYiCard>(o);
  }
};

public sealed class FB_JiYiCardContainer : Table {
  public static FB_JiYiCardContainer GetRootAsFB_JiYiCardContainer(ByteBuffer _bb) { return GetRootAsFB_JiYiCardContainer(_bb, new FB_JiYiCardContainer()); }
  public static FB_JiYiCardContainer GetRootAsFB_JiYiCardContainer(ByteBuffer _bb, FB_JiYiCardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiYiCardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiYiCardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiYiCard GetItems(int j) { return GetItems(new FB_JiYiCard(), j); }
  public FB_JiYiCard GetItems(FB_JiYiCard obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiYiCardContainer> CreateFB_JiYiCardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiYiCardContainer.AddItems(builder, items);
    return FB_JiYiCardContainer.EndFB_JiYiCardContainer(builder);
  }

  public static void StartFB_JiYiCardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiYiCard>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiYiCardContainer> EndFB_JiYiCardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiYiCardContainer>(o);
  }
  public static void FinishFB_JiYiCardContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiYiCardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
