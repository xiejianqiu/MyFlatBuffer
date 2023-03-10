// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_AttributeLess : Table {
  public static FB_AttributeLess GetRootAsFB_AttributeLess(ByteBuffer _bb) { return GetRootAsFB_AttributeLess(_bb, new FB_AttributeLess()); }
  public static FB_AttributeLess GetRootAsFB_AttributeLess(ByteBuffer _bb, FB_AttributeLess obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_AttributeLess __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CombatPower { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Attack { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Defence { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_AttributeLess> CreateFB_AttributeLess(FlatBufferBuilder builder,
      int Id = 0,
      int CombatPower = -1,
      int Attack = -1,
      int Defence = -1) {
    builder.StartObject(4);
    FB_AttributeLess.AddDefence(builder, Defence);
    FB_AttributeLess.AddAttack(builder, Attack);
    FB_AttributeLess.AddCombatPower(builder, CombatPower);
    FB_AttributeLess.AddId(builder, Id);
    return FB_AttributeLess.EndFB_AttributeLess(builder);
  }

  public static void StartFB_AttributeLess(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCombatPower(FlatBufferBuilder builder, int CombatPower) { builder.AddInt(1, CombatPower, -1); }
  public static void AddAttack(FlatBufferBuilder builder, int Attack) { builder.AddInt(2, Attack, -1); }
  public static void AddDefence(FlatBufferBuilder builder, int Defence) { builder.AddInt(3, Defence, -1); }
  public static Offset<FB_AttributeLess> EndFB_AttributeLess(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AttributeLess>(o);
  }
};

public sealed class FB_AttributeLessContainer : Table {
  public static FB_AttributeLessContainer GetRootAsFB_AttributeLessContainer(ByteBuffer _bb) { return GetRootAsFB_AttributeLessContainer(_bb, new FB_AttributeLessContainer()); }
  public static FB_AttributeLessContainer GetRootAsFB_AttributeLessContainer(ByteBuffer _bb, FB_AttributeLessContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_AttributeLessContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_AttributeLessContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_AttributeLess GetItems(int j) { return GetItems(new FB_AttributeLess(), j); }
  public FB_AttributeLess GetItems(FB_AttributeLess obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_AttributeLessContainer> CreateFB_AttributeLessContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_AttributeLessContainer.AddItems(builder, items);
    return FB_AttributeLessContainer.EndFB_AttributeLessContainer(builder);
  }

  public static void StartFB_AttributeLessContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_AttributeLess>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_AttributeLessContainer> EndFB_AttributeLessContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_AttributeLessContainer>(o);
  }
  public static void FinishFB_AttributeLessContainerBuffer(FlatBufferBuilder builder, Offset<FB_AttributeLessContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
