// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RebateRule : Table {
  public static FB_RebateRule GetRootAsFB_RebateRule(ByteBuffer _bb) { return GetRootAsFB_RebateRule(_bb, new FB_RebateRule()); }
  public static FB_RebateRule GetRootAsFB_RebateRule(ByteBuffer _bb, FB_RebateRule obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RebateRule __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MinimumRecharge { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TopUpRecharge { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Ceiling { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_RebateRule> CreateFB_RebateRule(FlatBufferBuilder builder,
      int Id = 0,
      int MinimumRecharge = -1,
      int TopUpRecharge = -1,
      int Ceiling = -1) {
    builder.StartObject(4);
    FB_RebateRule.AddCeiling(builder, Ceiling);
    FB_RebateRule.AddTopUpRecharge(builder, TopUpRecharge);
    FB_RebateRule.AddMinimumRecharge(builder, MinimumRecharge);
    FB_RebateRule.AddId(builder, Id);
    return FB_RebateRule.EndFB_RebateRule(builder);
  }

  public static void StartFB_RebateRule(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMinimumRecharge(FlatBufferBuilder builder, int MinimumRecharge) { builder.AddInt(1, MinimumRecharge, -1); }
  public static void AddTopUpRecharge(FlatBufferBuilder builder, int TopUpRecharge) { builder.AddInt(2, TopUpRecharge, -1); }
  public static void AddCeiling(FlatBufferBuilder builder, int Ceiling) { builder.AddInt(3, Ceiling, -1); }
  public static Offset<FB_RebateRule> EndFB_RebateRule(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RebateRule>(o);
  }
};

public sealed class FB_RebateRuleContainer : Table {
  public static FB_RebateRuleContainer GetRootAsFB_RebateRuleContainer(ByteBuffer _bb) { return GetRootAsFB_RebateRuleContainer(_bb, new FB_RebateRuleContainer()); }
  public static FB_RebateRuleContainer GetRootAsFB_RebateRuleContainer(ByteBuffer _bb, FB_RebateRuleContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RebateRuleContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RebateRuleContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RebateRule GetItems(int j) { return GetItems(new FB_RebateRule(), j); }
  public FB_RebateRule GetItems(FB_RebateRule obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RebateRuleContainer> CreateFB_RebateRuleContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RebateRuleContainer.AddItems(builder, items);
    return FB_RebateRuleContainer.EndFB_RebateRuleContainer(builder);
  }

  public static void StartFB_RebateRuleContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RebateRule>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RebateRuleContainer> EndFB_RebateRuleContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RebateRuleContainer>(o);
  }
  public static void FinishFB_RebateRuleContainerBuffer(FlatBufferBuilder builder, Offset<FB_RebateRuleContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
