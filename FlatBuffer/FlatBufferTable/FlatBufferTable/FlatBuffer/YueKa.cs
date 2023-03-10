// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_YueKa : Table {
  public static FB_YueKa GetRootAsFB_YueKa(ByteBuffer _bb) { return GetRootAsFB_YueKa(_bb, new FB_YueKa()); }
  public static FB_YueKa GetRootAsFB_YueKa(ByteBuffer _bb, FB_YueKa obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_YueKa __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MoneyNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int StrId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_YueKa> CreateFB_YueKa(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int MoneyNum = 0,
      int StrId = -1) {
    builder.StartObject(4);
    FB_YueKa.AddStrId(builder, StrId);
    FB_YueKa.AddMoneyNum(builder, MoneyNum);
    FB_YueKa.AddName(builder, Name);
    FB_YueKa.AddID(builder, ID);
    return FB_YueKa.EndFB_YueKa(builder);
  }

  public static void StartFB_YueKa(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddMoneyNum(FlatBufferBuilder builder, int MoneyNum) { builder.AddInt(2, MoneyNum, 0); }
  public static void AddStrId(FlatBufferBuilder builder, int StrId) { builder.AddInt(3, StrId, -1); }
  public static Offset<FB_YueKa> EndFB_YueKa(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_YueKa>(o);
  }
};

public sealed class FB_YueKaContainer : Table {
  public static FB_YueKaContainer GetRootAsFB_YueKaContainer(ByteBuffer _bb) { return GetRootAsFB_YueKaContainer(_bb, new FB_YueKaContainer()); }
  public static FB_YueKaContainer GetRootAsFB_YueKaContainer(ByteBuffer _bb, FB_YueKaContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_YueKaContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_YueKaContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_YueKa GetItems(int j) { return GetItems(new FB_YueKa(), j); }
  public FB_YueKa GetItems(FB_YueKa obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_YueKaContainer> CreateFB_YueKaContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_YueKaContainer.AddItems(builder, items);
    return FB_YueKaContainer.EndFB_YueKaContainer(builder);
  }

  public static void StartFB_YueKaContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_YueKa>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_YueKaContainer> EndFB_YueKaContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_YueKaContainer>(o);
  }
  public static void FinishFB_YueKaContainerBuffer(FlatBufferBuilder builder, Offset<FB_YueKaContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
