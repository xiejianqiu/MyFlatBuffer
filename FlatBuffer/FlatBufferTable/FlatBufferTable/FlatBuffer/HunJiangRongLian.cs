// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HunJiangRongLian : Table {
  public static FB_HunJiangRongLian GetRootAsFB_HunJiangRongLian(ByteBuffer _bb) { return GetRootAsFB_HunJiangRongLian(_bb, new FB_HunJiangRongLian()); }
  public static FB_HunJiangRongLian GetRootAsFB_HunJiangRongLian(ByteBuffer _bb, FB_HunJiangRongLian obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HunJiangRongLian __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Quality { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ItemCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DroBoxId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Tip { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_HunJiangRongLian> CreateFB_HunJiangRongLian(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int Quality = 0,
      int ItemCount = 0,
      int DroBoxId = 0,
      StringOffset Tip = default(StringOffset)) {
    builder.StartObject(6);
    FB_HunJiangRongLian.AddTip(builder, Tip);
    FB_HunJiangRongLian.AddDroBoxId(builder, DroBoxId);
    FB_HunJiangRongLian.AddItemCount(builder, ItemCount);
    FB_HunJiangRongLian.AddQuality(builder, Quality);
    FB_HunJiangRongLian.AddName(builder, Name);
    FB_HunJiangRongLian.AddId(builder, Id);
    return FB_HunJiangRongLian.EndFB_HunJiangRongLian(builder);
  }

  public static void StartFB_HunJiangRongLian(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(2, Quality, 0); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(3, ItemCount, 0); }
  public static void AddDroBoxId(FlatBufferBuilder builder, int DroBoxId) { builder.AddInt(4, DroBoxId, 0); }
  public static void AddTip(FlatBufferBuilder builder, StringOffset TipOffset) { builder.AddOffset(5, TipOffset.Value, 0); }
  public static Offset<FB_HunJiangRongLian> EndFB_HunJiangRongLian(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangRongLian>(o);
  }
};

public sealed class FB_HunJiangRongLianContainer : Table {
  public static FB_HunJiangRongLianContainer GetRootAsFB_HunJiangRongLianContainer(ByteBuffer _bb) { return GetRootAsFB_HunJiangRongLianContainer(_bb, new FB_HunJiangRongLianContainer()); }
  public static FB_HunJiangRongLianContainer GetRootAsFB_HunJiangRongLianContainer(ByteBuffer _bb, FB_HunJiangRongLianContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HunJiangRongLianContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HunJiangRongLianContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HunJiangRongLian GetItems(int j) { return GetItems(new FB_HunJiangRongLian(), j); }
  public FB_HunJiangRongLian GetItems(FB_HunJiangRongLian obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HunJiangRongLianContainer> CreateFB_HunJiangRongLianContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HunJiangRongLianContainer.AddItems(builder, items);
    return FB_HunJiangRongLianContainer.EndFB_HunJiangRongLianContainer(builder);
  }

  public static void StartFB_HunJiangRongLianContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HunJiangRongLian>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HunJiangRongLianContainer> EndFB_HunJiangRongLianContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HunJiangRongLianContainer>(o);
  }
  public static void FinishFB_HunJiangRongLianContainerBuffer(FlatBufferBuilder builder, Offset<FB_HunJiangRongLianContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
