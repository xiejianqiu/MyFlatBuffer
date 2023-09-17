// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ChatExpression : Table {
  public static FB_ChatExpression GetRootAsFB_ChatExpression(ByteBuffer _bb) { return GetRootAsFB_ChatExpression(_bb, new FB_ChatExpression()); }
  public static FB_ChatExpression GetRootAsFB_ChatExpression(ByteBuffer _bb, FB_ChatExpression obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ChatExpression __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Frames { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Class { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ChatExpression> CreateFB_ChatExpression(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int Frames = -1,
      int Class = -1) {
    builder.StartObject(5);
    FB_ChatExpression.AddClass(builder, Class);
    FB_ChatExpression.AddFrames(builder, Frames);
    FB_ChatExpression.AddIcon(builder, Icon);
    FB_ChatExpression.AddName(builder, Name);
    FB_ChatExpression.AddId(builder, Id);
    return FB_ChatExpression.EndFB_ChatExpression(builder);
  }

  public static void StartFB_ChatExpression(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddFrames(FlatBufferBuilder builder, int Frames) { builder.AddInt(3, Frames, -1); }
  public static void AddClass(FlatBufferBuilder builder, int Class) { builder.AddInt(4, Class, -1); }
  public static Offset<FB_ChatExpression> EndFB_ChatExpression(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChatExpression>(o);
  }
};

public sealed class FB_ChatExpressionContainer : Table {
  public static FB_ChatExpressionContainer GetRootAsFB_ChatExpressionContainer(ByteBuffer _bb) { return GetRootAsFB_ChatExpressionContainer(_bb, new FB_ChatExpressionContainer()); }
  public static FB_ChatExpressionContainer GetRootAsFB_ChatExpressionContainer(ByteBuffer _bb, FB_ChatExpressionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ChatExpressionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ChatExpressionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ChatExpression GetItems(int j) { return GetItems(new FB_ChatExpression(), j); }
  public FB_ChatExpression GetItems(FB_ChatExpression obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChatExpressionContainer> CreateFB_ChatExpressionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ChatExpressionContainer.AddItems(builder, items);
    return FB_ChatExpressionContainer.EndFB_ChatExpressionContainer(builder);
  }

  public static void StartFB_ChatExpressionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ChatExpression>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChatExpressionContainer> EndFB_ChatExpressionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChatExpressionContainer>(o);
  }
  public static void FinishFB_ChatExpressionContainerBuffer(FlatBufferBuilder builder, Offset<FB_ChatExpressionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
