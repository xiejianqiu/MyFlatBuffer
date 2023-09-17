// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_BloodBase : Table {
  public static FB_BloodBase GetRootAsFB_BloodBase(ByteBuffer _bb) { return GetRootAsFB_BloodBase(_bb, new FB_BloodBase()); }
  public static FB_BloodBase GetRootAsFB_BloodBase(ByteBuffer _bb, FB_BloodBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_BloodBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Exp { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attack { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Defence { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HP { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_BloodBase> CreateFB_BloodBase(FlatBufferBuilder builder,
      int ID = 0,
      int Exp = -1,
      int Attack = -1,
      int Defence = -1,
      int HP = -1) {
    builder.StartObject(5);
    FB_BloodBase.AddHP(builder, HP);
    FB_BloodBase.AddDefence(builder, Defence);
    FB_BloodBase.AddAttack(builder, Attack);
    FB_BloodBase.AddExp(builder, Exp);
    FB_BloodBase.AddID(builder, ID);
    return FB_BloodBase.EndFB_BloodBase(builder);
  }

  public static void StartFB_BloodBase(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(1, Exp, -1); }
  public static void AddAttack(FlatBufferBuilder builder, int Attack) { builder.AddInt(2, Attack, -1); }
  public static void AddDefence(FlatBufferBuilder builder, int Defence) { builder.AddInt(3, Defence, -1); }
  public static void AddHP(FlatBufferBuilder builder, int HP) { builder.AddInt(4, HP, -1); }
  public static Offset<FB_BloodBase> EndFB_BloodBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BloodBase>(o);
  }
};

public sealed class FB_BloodBaseContainer : Table {
  public static FB_BloodBaseContainer GetRootAsFB_BloodBaseContainer(ByteBuffer _bb) { return GetRootAsFB_BloodBaseContainer(_bb, new FB_BloodBaseContainer()); }
  public static FB_BloodBaseContainer GetRootAsFB_BloodBaseContainer(ByteBuffer _bb, FB_BloodBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_BloodBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_BloodBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_BloodBase GetItems(int j) { return GetItems(new FB_BloodBase(), j); }
  public FB_BloodBase GetItems(FB_BloodBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_BloodBaseContainer> CreateFB_BloodBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_BloodBaseContainer.AddItems(builder, items);
    return FB_BloodBaseContainer.EndFB_BloodBaseContainer(builder);
  }

  public static void StartFB_BloodBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_BloodBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_BloodBaseContainer> EndFB_BloodBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_BloodBaseContainer>(o);
  }
  public static void FinishFB_BloodBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_BloodBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
