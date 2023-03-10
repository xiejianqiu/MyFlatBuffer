// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ChatWordExpression : Table {
  public static FB_ChatWordExpression GetRootAsFB_ChatWordExpression(ByteBuffer _bb) { return GetRootAsFB_ChatWordExpression(_bb, new FB_ChatWordExpression()); }
  public static FB_ChatWordExpression GetRootAsFB_ChatWordExpression(ByteBuffer _bb, FB_ChatWordExpression obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ChatWordExpression __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string GetContentList(int j) { int o = __offset(8); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int ContentListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChatWordExpression> CreateFB_ChatWordExpression(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      VectorOffset ContentList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_ChatWordExpression.AddContentList(builder, ContentList);
    FB_ChatWordExpression.AddName(builder, Name);
    FB_ChatWordExpression.AddId(builder, Id);
    return FB_ChatWordExpression.EndFB_ChatWordExpression(builder);
  }

  public static void StartFB_ChatWordExpression(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddContentList(FlatBufferBuilder builder, VectorOffset ContentListOffset) { builder.AddOffset(2, ContentListOffset.Value, 0); }
  public static VectorOffset CreateContentListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartContentListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChatWordExpression> EndFB_ChatWordExpression(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChatWordExpression>(o);
  }
};

public sealed class FB_ChatWordExpressionContainer : Table {
  public static FB_ChatWordExpressionContainer GetRootAsFB_ChatWordExpressionContainer(ByteBuffer _bb) { return GetRootAsFB_ChatWordExpressionContainer(_bb, new FB_ChatWordExpressionContainer()); }
  public static FB_ChatWordExpressionContainer GetRootAsFB_ChatWordExpressionContainer(ByteBuffer _bb, FB_ChatWordExpressionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ChatWordExpressionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ChatWordExpressionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ChatWordExpression GetItems(int j) { return GetItems(new FB_ChatWordExpression(), j); }
  public FB_ChatWordExpression GetItems(FB_ChatWordExpression obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChatWordExpressionContainer> CreateFB_ChatWordExpressionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ChatWordExpressionContainer.AddItems(builder, items);
    return FB_ChatWordExpressionContainer.EndFB_ChatWordExpressionContainer(builder);
  }

  public static void StartFB_ChatWordExpressionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ChatWordExpression>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChatWordExpressionContainer> EndFB_ChatWordExpressionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChatWordExpressionContainer>(o);
  }
  public static void FinishFB_ChatWordExpressionContainerBuffer(FlatBufferBuilder builder, Offset<FB_ChatWordExpressionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
