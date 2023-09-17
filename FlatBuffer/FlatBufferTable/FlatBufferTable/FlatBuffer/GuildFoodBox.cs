// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GuildFoodBox : Table {
  public static FB_GuildFoodBox GetRootAsFB_GuildFoodBox(ByteBuffer _bb) { return GetRootAsFB_GuildFoodBox(_bb, new FB_GuildFoodBox()); }
  public static FB_GuildFoodBox GetRootAsFB_GuildFoodBox(ByteBuffer _bb, FB_GuildFoodBox obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GuildFoodBox __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Foods { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ExpBonus { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MoneyBonus { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_GuildFoodBox> CreateFB_GuildFoodBox(FlatBufferBuilder builder,
      int Id = 0,
      int Foods = -1,
      int ExpBonus = -1,
      int MoneyBonus = -1) {
    builder.StartObject(4);
    FB_GuildFoodBox.AddMoneyBonus(builder, MoneyBonus);
    FB_GuildFoodBox.AddExpBonus(builder, ExpBonus);
    FB_GuildFoodBox.AddFoods(builder, Foods);
    FB_GuildFoodBox.AddId(builder, Id);
    return FB_GuildFoodBox.EndFB_GuildFoodBox(builder);
  }

  public static void StartFB_GuildFoodBox(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddFoods(FlatBufferBuilder builder, int Foods) { builder.AddInt(1, Foods, -1); }
  public static void AddExpBonus(FlatBufferBuilder builder, int ExpBonus) { builder.AddInt(2, ExpBonus, -1); }
  public static void AddMoneyBonus(FlatBufferBuilder builder, int MoneyBonus) { builder.AddInt(3, MoneyBonus, -1); }
  public static Offset<FB_GuildFoodBox> EndFB_GuildFoodBox(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildFoodBox>(o);
  }
};

public sealed class FB_GuildFoodBoxContainer : Table {
  public static FB_GuildFoodBoxContainer GetRootAsFB_GuildFoodBoxContainer(ByteBuffer _bb) { return GetRootAsFB_GuildFoodBoxContainer(_bb, new FB_GuildFoodBoxContainer()); }
  public static FB_GuildFoodBoxContainer GetRootAsFB_GuildFoodBoxContainer(ByteBuffer _bb, FB_GuildFoodBoxContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GuildFoodBoxContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GuildFoodBoxContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GuildFoodBox GetItems(int j) { return GetItems(new FB_GuildFoodBox(), j); }
  public FB_GuildFoodBox GetItems(FB_GuildFoodBox obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuildFoodBoxContainer> CreateFB_GuildFoodBoxContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GuildFoodBoxContainer.AddItems(builder, items);
    return FB_GuildFoodBoxContainer.EndFB_GuildFoodBoxContainer(builder);
  }

  public static void StartFB_GuildFoodBoxContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GuildFoodBox>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuildFoodBoxContainer> EndFB_GuildFoodBoxContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuildFoodBoxContainer>(o);
  }
  public static void FinishFB_GuildFoodBoxContainerBuffer(FlatBufferBuilder builder, Offset<FB_GuildFoodBoxContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
